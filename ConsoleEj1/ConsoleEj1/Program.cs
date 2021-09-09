using LibEj1;
using System;

namespace ConsoleEj1
{
	class Program
	{
		static void Main(string[] args)
		{
			//int t;
			//t = 0;
			int t = 0;
			//Saraza saraza;
			//saraza = new Saraza();
			//Saraza2 saraza2 = new Saraza2();
			
			Saraza saraza = new Saraza();
			Saraza saraza2 = new Saraza();

			saraza.XXXXX = 10;
			saraza2.XXXXX = 20;
			//t = saraza.ProcesarX();

			//Console.WriteLine("El valor de T es: " + t);

			saraza.ProcesarX();
			saraza2.ProcesarX();

			Console.WriteLine("El valor de X es: " + saraza.XXXXX);
			Console.WriteLine("El valor de X es: " + saraza2.XXXXX);

			Console.ReadLine();

		}
	}
}