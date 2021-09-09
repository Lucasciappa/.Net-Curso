using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
	public class MenuAbrir : Menu, ICommand
	{
		public MenuAbrir(string text) : base(text)
		{

		}

		public override void Execute()
		{
			Console.WriteLine("Alguien me dio click, soy " + base._text);
		}
	}
}
