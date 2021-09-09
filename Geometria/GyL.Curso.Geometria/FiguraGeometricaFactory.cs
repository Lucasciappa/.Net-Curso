using System;
using System.Collections.Generic;
using System.Text;

namespace GyL.Curso.Geometria
{
	public static class FiguraGeometricaFactory
	{
		public static FiguraGeometrica Create(int index)
		{
			switch (index)
			{
				case 1:
					float radio;
					do
					{
						Console.WriteLine("Ingrese el radio:");
						radio = float.Parse(Console.ReadLine());
					} while (radio <= 0);
					Circulo circulo = new Circulo(radio);
					circulo.Nombre = "Circulito";
					return circulo;
				case 2:
					float b;
					float a;
					do
					{
						Console.WriteLine("Ingrese la base:");
						b = float.Parse(Console.ReadLine());
					} while (b <= 0);
					do
					{
						Console.WriteLine("Ingrese la altura:");
						a = float.Parse(Console.ReadLine());
					} while (a <= 0);
					Triangulo triangulo = new Triangulo(b, a);
					triangulo.Nombre = "Triangulito";
					return triangulo;
				default:
					throw new Exception("No existe la figura.");
			}
		}

		public static FiguraGeometrica Create(string name)
		{
			switch (name)
			{
				case "Circulo":
					float radio;
					do
					{
						Console.WriteLine("Ingrese el radio:");
						radio = float.Parse(Console.ReadLine());
					} while (radio <= 0);
					Circulo circulo = new Circulo(radio);
					circulo.Nombre = "Circulito";
					return circulo;
				case "Triangulo":
					float b;
					float a;
					do
					{
						Console.WriteLine("Ingrese la base:");
						b = float.Parse(Console.ReadLine());
					} while (b <= 0);
					do
					{
						Console.WriteLine("Ingrese la altura:");
						a = float.Parse(Console.ReadLine());
					} while (a <= 0);
					Triangulo triangulo = new Triangulo(b, a);
					triangulo.Nombre = "Triangulito";
					return triangulo;
				default:
					throw new Exception("No existe la figura '" + name + "'");
			}
		}
	}
}
