using System;
using System.Collections.Generic;
using System.Text;

namespace GyL.Curso.Geometria
{
	public class Triangulo : FiguraGeometrica, IAreaCalculable
	{
		public Triangulo() 
		{
		}

		public Triangulo(float b, float a )
		{
			_base = b;
			_altura = a;
		}

		public Triangulo(float b, float a, string nombre)
		{
			_base = b;
			_altura = a;
			Nombre = nombre;
		}

		private float _base;
		private float _altura;

		public float Base { get => _base; set => _base = value; }
		public float Altura { get => _altura; set => _altura = value; }

		public override float CalcularArea()
		{
			Area =_base*_altura/2;
			return Area;
		}

		public override void MostrarArea()
		{
			Console.WriteLine("El area del triangulo '" + this.Nombre + "' es: " + this.Area);
		}
	}
}
