using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
	public interface IEjemplo<X, Z>
	{
		X GetId(Z name);
		X GetId(Z name, X dato);
	}

	public class Ejemplo<X, Z> : IEjemplo<X, Z> where X : class, new()
	{
		public X GetId(Z name)
		{
			X dato = new X();
			return dato;
		}

		public X GetId(Z name, X dato)
		{
			return dato;
		}
	}

	public class Ejemplo2<X, Z> : IEjemplo<X, Z>
	{
		public X GetId(Z name, X dato)
		{
			return dato;
		}

		public X GetId(Z name)
		{
			throw new NotImplementedException();
		}
	}

}
