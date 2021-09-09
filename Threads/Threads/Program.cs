using System;
using System.Threading;

namespace Threads
{
	class Program
	{
		static void Main(string[] args)
		{
			//(5 + 9) * (8 + 3)
			Sumador sumador1 = new Sumador(5, 9);
			//sumador1.Resolver();
			Sumador sumador2 = new Sumador(8, 3);
			//sumador2.Resolver();


			ThreadStart threadStart1 = new ThreadStart(sumador1.Resolver);
			Thread thread1 = new Thread(threadStart1);

			ThreadStart threadStart2 = new ThreadStart(sumador2.Resolver);
			Thread thread2 = new Thread(threadStart2);

			thread1.Start();
			thread2.Start();
			
			thread1.Join();
			thread2.Join();

			int r = sumador1.Resultado * sumador2.Resultado;

			Console.WriteLine("Resultado:" + r);
		}
	}
}
