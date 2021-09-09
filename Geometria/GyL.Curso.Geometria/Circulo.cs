using System;
using System.Collections.Generic;
using System.Text;

namespace GyL.Curso.Geometria
{
	public class Circulo : FiguraGeometrica
	{
		private float _radio;

		public float Radio { get => _radio; set => _radio = value; }

		public Circulo()
		{
		}

		public Circulo(float radio)
		{
			this._radio = radio;
		}

		public override float CalcularArea()
		{
			base.Area = (float)(Math.PI * Math.Pow(this._radio, 2));
			_counter++;
			return base.Area;
		}

		public new void MostrarArea()
		{
			Console.WriteLine("El area del circulo '" + this.Nombre + "' es: " + this.Area);
		}
	}
}
