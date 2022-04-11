using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Exceptions
{
    internal class InvalidCaliberException : Exception
    {
        public InvalidCaliberException(string message) : base(message)
        {
        }
    }
}
