using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace PrinterSpool
{
	public class PrinterSpool
	{
		private static PrinterSpool _instance;
		private static readonly object _lock = new object();
		private static Queue<Document> _queue = new Queue<Document>();
		private static ManualResetEventSlim _manualResetEventSlim = new ManualResetEventSlim(true);
		private static ConcurrentQueue<PrintTask> _concurrentQueue = new ConcurrentQueue<PrintTask>();
		private static BlockingCollection<PrintTask> _blockingCollection = new BlockingCollection<PrintTask>(_concurrentQueue);

		private PrinterSpool()
		{
			var thread = new Thread(() =>
			{
				while (!_blockingCollection.IsCompleted)
				{
					var innerThread = new Thread(() =>
					{
						PrintTask printer = null;
						_manualResetEventSlim.Wait();
						_manualResetEventSlim.Reset();
						try
						{
							printer = _blockingCollection.Take();
						}
						catch (InvalidOperationException) { }

						printer?.Print();
					})
					{
						IsBackground = true
					};
					//ThreadStart threadStart = new ThreadStart(() =>
					//{
					//	PrintTask printer = null;
					//	_manualResetEventSlim.Wait();
					//	_manualResetEventSlim.Reset();
					//	try
					//	{
					//		printer = _blockingCollection.Take();
					//	}
					//	catch (InvalidOperationException) { }
					//	printer?.Print();
					//});
					//var innerThread = new Thread(threadStart);
					//innerThread.IsBackground = true;
					innerThread.Start();
				}
			})
			{
				IsBackground = true
			};
			thread.Start();
		}

		public static PrinterSpool Instance
		{
			get
			{
				if (_instance == null)
				{
					lock (_lock)
					{
						if (_instance == null)
							_instance = new PrinterSpool();
					}
				}
				return _instance;
			}
		}

		public void Print(Document document)
		{
			_queue.Enqueue(document);
			if (_queue.Count == 1)
			{
				var printTask = new PrintTask(document);
				printTask.OnPrintFinished += this.OnPrintFinishedHandler;
				_blockingCollection.Add(printTask);
			}
		}

		private void OnPrintFinishedHandler(object obj, PrintFinishedArgs arg)
		{
			_queue.Dequeue();
			if (_queue.Count == 0)
				Console.WriteLine("No quedan documentos en la cola...!");
			else
			{
				var document = _queue.Peek();
				var printTask = new PrintTask(document);
				printTask.OnPrintFinished += this.OnPrintFinishedHandler;
				_blockingCollection.Add(printTask);
			}
			_manualResetEventSlim.Set();
		}
	}
}
