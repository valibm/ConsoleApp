using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Models
{
    internal class Pistol : Gun
    {
        public Pistol(string name, string kind) : base(name, kind)
        {

        }
        public override string GetInformation()
        {
            return $"{Kind}|{Name}";
        }
        public override string ToString()
        {
            return $"{Kind}|{Name}";
        }

    }
}
