using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
	public class MenuEditar : Menu, ICommand
	{
		public MenuEditar(string text) : base(text)
		{

		}

		public override void Execute()
		{
			Console.WriteLine("Alguien me dio click, soy Editar" + base._text);
		}

	}

}
