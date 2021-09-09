using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	public class Menu : ICommand
	{
		protected string _text;
		public Menu(string text) 
		{
			_text = text;
			Console.WriteLine(text);
		}

		public virtual void Execute()
		{
			Console.WriteLine("Alguien me dio click, soy " + _text);
		}
	}
}
