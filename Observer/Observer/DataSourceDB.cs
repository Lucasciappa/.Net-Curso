using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
	public class DataSourceDB<T> : Observable<T>
	{
		public DataSourceDB()
		{
		}
		public DataSourceDB(T data)
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
