using System;
using System.Collections.Generic;

namespace Command
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, Menu> menues = new Dictionary<int, Menu>();
			for (int i = 1; i < 11; i++)
			{
				if (i % 2 == 0)
					menues.Add(i, new MenuAbrir("Menu-" + i));
				else
					menues.Add(i, new MenuEditar("Menu-" + i));
			}

			menues.Add(11, new Menu("Menu-" + 11));

			int clickRandom = (new Random().Next(1, 11));

			Menu menu;
			if (menues.TryGetValue(clickRandom, out menu))
				menu.Execute();
			else
				Console.WriteLine("No existe ese menu");
		}
	}
}
