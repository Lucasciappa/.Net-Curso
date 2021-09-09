using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
	public interface IObserver<T>
	{
		public void Update(T data);
	}

	public abstract class Observer<T> : IObserver<T>, IDisposable
	{
		protected T _data;

		#region --Constructors & Destructors--
		public Observer()
		{

		}
		public Observer(T data)
		{
			this._data = data;
		}
		~Observer()
		{
			Dispose(false);
		}
		#endregion

		public abstract void Update(T data);

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
			}
		}
		#endregion
	}

}
