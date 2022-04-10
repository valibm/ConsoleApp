using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Exceptions
{
    internal class CapacityOutOfRangeException : Exception
    {
        public CapacityOutOfRangeException(string message) : base(message) {}
    }
}
