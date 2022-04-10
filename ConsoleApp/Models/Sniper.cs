using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp.Interfaces;
using ConsoleApp.Helpers;
using ConsoleApp.Exceptions;

namespace ConsoleApp.Models
{
    internal class Sniper : Gun, ISingleShot
    {
        public override int Capacity
        {
            get { return 4; }
            set
            {
                if (_capacity < 0 && _capacity > 4)
                {
                    throw new CapacityOutOfRangeException("Capacity is not acceptable.");
                }
                _capacity = value;
            }
        }
        public Sniper()
        {
            Kind = "Sniper";
            CurrentBulletCount = Capacity;
            CreatedDate = DateTime.Now;
        }
        public Sniper(string name, Bullet bulletType) : base(name, bulletType)
        { 
        }
        public override string ToString()
        {
            return $"{Id}.{Kind}|{Name} - - is a high-precision, long-range rifle, using {BulletType} cartridge";
        }
        public void Shoot()
        {
            if (CurrentBulletCount != 0)
            {
                CurrentBulletCount--;
                return;
            }
            Console.WriteLine(Constants.OutOfBulletMessage);
        }
    }
}
