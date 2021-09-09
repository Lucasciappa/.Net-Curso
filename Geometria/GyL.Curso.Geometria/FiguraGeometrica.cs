using System;

namespace GyL.Curso.Geometria
{
	public abstract class FiguraGeometrica : IAreaCalculable, IAreaMostrable
	{
		private float _area;
		private string _nombre;
		public static float _counter = 0;

		public float Area
		{
			get => _area;
			protected set
			{
				if (value < 0)
					throw new Exception("El area no puede ser negativa.");
				_area = value;
			}
		}
		public string Nombre { get => _nombre; set => _nombre = value; }

		public abstract float CalcularArea();

		public virtual void MostrarArea()
		{
			Console.WriteLine("El area de la figura '" + this.Nombre + "' es: " + this.Area);
		}

		public static void Incrementar() 
		{
			_counter++;
			Console.WriteLine("Contador " + _counter);
		}

		public static void Decrementar()
		{
			_counter--; // _counter = _counter - 1;
			Console.WriteLine("Contador " + _counter);
		}

	}
}
