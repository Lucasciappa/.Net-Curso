using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
	public class PearsonDTO : IDisposable
	{
		private string _name;
		private int _age;
		public PearsonDTO(string name, int age)
		{
			_name = name;
			_age = age;
		}

		public void Dispose()
		{
			Console.WriteLine("Dispose PearsonDTO");
		}

		public override string ToString()
		{
			return "Soy " + _name + " y tengo " + _age.ToString() + " años..!";
		}
	}

}
