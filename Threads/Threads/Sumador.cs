using System;
using System.Collections.Generic;
using System.Text;

namespace Threads
{
	public class Sumador
	{
		private int _a;
		private int _b;
		private int _r;
		public Sumador(int a, int b) 
		{
			_a = a;
			_b = b;
		}

		public int Resultado { get => _r; set => _r = value; }

		public void Resolver() 
		{
			_r = _a + _b;
			Console.WriteLine("Resultado: " + _r);
		}
	}
}
