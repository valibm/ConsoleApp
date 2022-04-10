using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp.Models;

namespace ConsoleApp.Interfaces
{
    internal interface ISingleShot
    {
        /// <summary>
        /// Shoots one bullet at a time
        /// </summary>
        public void Shoot();
    }
}
