using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
	public class DataSource<T> : Observable<T>
	{
		public DataSource()
		{
		}
		public DataSource(T data)
		{
			this._data = data;
		}

		public void Process(T data)
		{
			this._data = data;
			this.Notify();
		}
	}

}
