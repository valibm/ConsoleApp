using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp.Interfaces;
using ConsoleApp.Helpers;
using ConsoleApp.Exceptions;

namespace ConsoleApp.Models
{
    internal class Pistol : Gun, ISingleShot
    {
        public override int Capacity
        {
            get { return 17; }
            set
            {
                if (_capacity < 0 && _capacity > 17)
                {
                    throw new CapacityOutOfRangeException("Capacity is not acceptable.");
                }
                _capacity = value;
            }
        }
        public Pistol()
        {
            Kind = "Pistol";
            CurrentBulletCount = Capacity;
            CreatedDate = DateTime.Now;
        }
        public Pistol(string name, Bullet bulletType) : base(name, bulletType)
        {
        }
        public override string ToString()
        {
            return $"{Id}.{Kind}|{Name} - is a hand-operated firearm using {BulletType} cartridge ";
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
