namespace PrinterSpool
{
	public class Document
	{
		private string _name;

		public Document(string name) 
		{
			_name = name;
		}

		public string Name { get => _name; set => _name = value; }
	}
}
