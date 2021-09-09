using GyL.Curso.Geometria;
using System;

namespace Geometria
{
	class Program
	{
		static void MostrarArea(IAreaMostrable areaMostrable)
		{
			areaMostrable.MostrarArea();
		}

		static void MostrarArea(FiguraGeometrica areaMostrable)
		{
			areaMostrable.MostrarArea();
		}

		static void Main(string[] args)
		{
			FiguraGeometrica figura = null;
			int option;

			do
			{
				Console.WriteLine("1 - Circulo");
				Console.WriteLine("2 - Triangulo");
				Console.WriteLine("0 para terminar");

				do
				{
					Console.WriteLine("Ingrese una opcion:");
					option = int.Parse(Console.ReadLine());
				} while (option > 2 && option < 0);

				if (option != 0)
					//figura = FiguraGeometricaFactory.Create(option);
					figura = FiguraGeometricaSingleton.Instance.Create(option);

				if (option != 0 && option < 3)
					MostrarArea(figura);
			} while (option != 0);

			////Triangulo triangulo = new Triangulo(2, 2, "Triangulin");
			//figura = new Triangulo(2, 2);
			//figura.Nombre = "Triangulin";
			////triangulo.Base = 1;
			////triangulo.Altura = 1;
			//figura.CalcularArea();
			////Console.WriteLine("El area del triangulo '" + triangulo.Nombre + "' es: " + triangulo.Area);
			////figura.MostrarArea();
			//MostrarArea(figura);

			//figura = new Circulo(1);
			//figura.Nombre = "Circulito";
			//figura.CalcularArea();
			////figura.MostrarArea();
			//MostrarArea(figura);

			//MostrarArea((IAreaMostrable)figura);

			//IAreaMostrable figura2 = new Circulo(1);
			////figura.MostrarArea();
			//MostrarArea(figura2);

		}
	}
}
