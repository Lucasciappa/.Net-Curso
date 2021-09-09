using System;
using System.Threading;

namespace PrinterSpool
{
	public class PrintTask
	{
		public delegate void PrintFinishedHandler(object obj, PrintFinishedArgs arg);
		public event PrintFinishedHandler OnPrintFinished;

		private Document _document;
		public PrintTask(Document document) 
		{
			_document = document;
		}
		
		public void Print() 
		{
			//simulamos una demora en la impresion
			Console.WriteLine("Imprimiendo " + _document.Name);
			int milliseconds = (new Random().Next(1, 3) * 1000);
			Thread.Sleep(milliseconds);
			OnPrintFinished(_document, new PrintFinishedArgs("Finished print " + _document.Name));
		}
	}
}
