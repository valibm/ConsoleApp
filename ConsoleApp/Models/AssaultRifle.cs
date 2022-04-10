using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp.Interfaces;
using ConsoleApp.Helpers;
using ConsoleApp.Exceptions;

namespace ConsoleApp.Models
{
    internal class AssaultRifle : Gun, ISingleShot
    {
        public override int Capacity
        {
            get { return 30; }
            set
            {
                if (_capacity < 0 && _capacity > 45)
                {
                    throw new CapacityOutOfRangeException("Capacity is not acceptable.");
                }
                _capacity = value;
            }
        }
        public AssaultRifle()
        {
            Kind = "AssaultRifle";
            CurrentBulletCount = Capacity;
            CreatedDate = DateTime.Now;
        }
        public AssaultRifle(string name, Bullet bulletType) : base(name, bulletType)
        {

        }
        public override string ToString()
        {
            return $"{Id}.{Kind}|{Name} - is a lightweight rifle which may be set to fire automatically or semi-automatically, using {BulletType} cartridge";
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
