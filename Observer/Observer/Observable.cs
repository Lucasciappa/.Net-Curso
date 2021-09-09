using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
	public interface IObservable<T>
	{
		public void Subscribe(IObserver<T> observer);
		public void Unsubscribe(IObserver<T> observer);
		public void UnsubscribeAll();
		public void Notify();
	}

	public abstract class Observable<T> : IObservable<T>, IDisposable
	{
		private List<IObserver<T>> observers = new List<IObserver<T>>();
		protected T _data;

		#region --Constructors & Destructors--
		public Observable()
		{

		}
		~Observable()
		{
			observers.Clear();
			Dispose(false);
		}
		#endregion

		#region --IObservable methods--
		public void Notify()
		{
			foreach (var observer in observers)
				observer.Update(_data);
		}
		public void Subscribe(IObserver<T> observer)
		{
			if (!observers.Contains(observer))
				observers.Add(observer);
		}
		public void Unsubscribe(IObserver<T> observer)
		{
			if (observers.Contains(observer))
				observers.Remove(observer);
		}
		public void UnsubscribeAll()
		{
			observers.Clear();
		}
		#endregion

		#region --IDisposable methods--
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		protected void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (_data is IDisposable)
					((IDisposable)_data).Dispose();
				observers.Clear();
			}
		}
		#endregion
	}

}
