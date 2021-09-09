using System;

namespace PrinterSpool
{
	public class PrintFinishedArgs : EventArgs
	{
        private readonly string _message;
        public string Message { get { return _message; } }

        public PrintFinishedArgs(string message)
        {
            this._message = message;
        }
    }
}
