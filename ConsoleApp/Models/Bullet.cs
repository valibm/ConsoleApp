using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp.Exceptions;
using ConsoleApp.Helpers;

namespace ConsoleApp.Models
{
    internal class Bullet
    {
        private double _caliber;
        public string Type { get; set; }
        public double Caliber 
        {
            get => _caliber;
            set 
            {
                if (_caliber < 0)
                {
                    throw new InvalidCaliberException(Constants.WrongCaliberMessage);
                }
                _caliber = value;
            }
        }
        public Bullet(double caliber, string type)
        {
            _caliber = caliber;
            Type = type;
        }
        public override string ToString()
        {
            return $"{Caliber}mm {Type}";
        }
    }
}
