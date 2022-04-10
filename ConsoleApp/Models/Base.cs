using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Models
{
    internal abstract class Base
    {
        private static int _idCounter;

        public int Id { get; set; }
        protected string Kind { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public static DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        static Base()
        {
            _idCounter = 0;
        }
        public Base()
        {

        }
        public Base(string name)
        {
            Name = name;
            Id = ++_idCounter;
        }

    }
}
