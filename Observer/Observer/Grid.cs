using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
	public class Grid<T> : Observer<T>
	{
		public Grid() : base()
		{

		}
		public Grid(T data) : base(data)
		{

		}
		public override void Update(T data)
		{
			Console.WriteLine("Hola soy Grid -> " + data.ToString());
		}
	}

}
