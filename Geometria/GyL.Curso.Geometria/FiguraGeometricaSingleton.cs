using System;
using System.Collections.Generic;
using System.Text;

namespace GyL.Curso.Geometria
{
	public class FiguraGeometricaSingleton
	{
		private static FiguraGeometricaSingleton _instance;
		private static readonly object _lock = new object();

		private FiguraGeometricaSingleton()
		{
		}

		public static FiguraGeometricaSingleton Instance
		{
			get
			{
				if (_instance == null)
				{
					lock (_lock)
					{
						if (_instance == null)
							_instance = new FiguraGeometricaSingleton();
					}
				}
				return _instance;
			}
		}

		public FiguraGeometrica Create(int index)
		{
			return FiguraGeometricaFactory.Create(index);
		}
	}
}
