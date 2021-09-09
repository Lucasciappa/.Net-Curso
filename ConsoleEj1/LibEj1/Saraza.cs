using System;
using System.Collections.Generic;
using System.Text;

namespace LibEj1
{
	public class Saraza
	{
		private int x = 99;

		public int XXXXX {
			get
			{
				if (x > 10)
					return x;
				else
					return 0;
			}
			set 
			{
				if (value > 0)
					x = value;
			}
		}

		private void Incrementar()
		{
			x = x + 1;
		}

		public int ProcesarX() {
			Incrementar();
			return x;
		}
	}
}
