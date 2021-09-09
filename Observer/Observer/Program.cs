using System;
using System.Collections.Generic;

namespace Observer
{
    class Program
    {
		static void run()
		{

			Ejemplo<DataSource<int>, string> ejemplo1 = new Ejemplo<DataSource<int>, string>();
			DataSource<int> valor = ejemplo1.GetId("string");

			Ejemplo2<string, int> ejemplo2 = new Ejemplo2<string, int>();
			string valor2 = ejemplo2.GetId(2, "dsadsadsa");


			//try
			//{
			//	throw new Exception("Saraza");
			//	throw new NotImplementedException();

			//	int t = 0;
			//	int y = 1 / t;
			//}
			//catch (NotImplementedException e)
			//{
			//	string msg = "Ocurrio un error.";
			//}
			//catch (Exception e)
			//{
			//	string msg = "Ocurrio un error.";
			//}



			//----------------Observer-----------------------

			DataSource<string> observable = new DataSource<string>("Soy un observable sin datos :(");

			var graph = new Graph<string>();
			observable.Subscribe(graph);

			observable.Subscribe(new Graph<string>());
			observable.Subscribe(new Grid<string>());

			observable.Notify();

			Console.ReadKey();

			observable.Process("Soy un observable con datos :)");

			observable.Unsubscribe(graph);

			observable.UnsubscribeAll();

			observable.Dispose();

			Console.ReadKey();

			using (DataSource<PearsonDTO> observable2 = new DataSource<PearsonDTO>())
			{
				observable2.Subscribe(new Graph<PearsonDTO>());
				observable2.Subscribe(new Grid<PearsonDTO>());

				observable2.Process(new PearsonDTO("Jose", 45));
				observable2.Process(new PearsonDTO("Maria", 47));
				observable2.Process(new PearsonDTO("Agustina", 10));
			}

		}

		static void Main(string[] args)
		{
			run();


			GC.Collect();
			Console.ReadKey();
		}

	}
}
