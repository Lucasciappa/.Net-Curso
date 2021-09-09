using System;

namespace PrinterSpool
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0; i < 10; i++)
				PrinterSpool.Instance.Print(new Document("Saraza " + i + ".doc"));

			Console.WriteLine();
			Console.WriteLine("Presione una tecla para seguir imprimiendo");
			Console.WriteLine();
			Console.ReadKey();

			PrinterSpool.Instance.Print(new Document("Saraza.doc"));

			Console.WriteLine();
			Console.WriteLine("Presione una tecla para seguir imprimiendo");
			Console.WriteLine();
			Console.ReadKey();

			for (int i = 0; i < 10; i++)
				PrinterSpool.Instance.Print(new Document("Saraza " + i + ".xls"));

			char fin;
			do
			{
				Console.WriteLine(); 
				Console.WriteLine();
				Console.WriteLine("Presione x para finalizar..!");
				fin = (char)Console.ReadKey().Key;
			} while (fin != 'X');

			Environment.Exit(0);
		}
	}

}
