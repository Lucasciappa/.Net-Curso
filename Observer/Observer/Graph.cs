using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
	public class Graph<T> : Observer<T>
	{
		public Graph() : base()
		{

		}
		public Graph(T data) : base(data)
		{

		}

		public override void Update(T data)
		{
			Console.WriteLine("Hola soy Graph -> " + data.ToString());
		}
	}

}
