using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp.Interfaces;
using ConsoleApp.Helpers;
using ConsoleApp.Exceptions;
using Indexer1;

namespace ConsoleApp.Models
{
    internal class Smg : Gun, ISingleShot, IBurstShoot
    {
        public override int Capacity
        {
            get { return 45; }
            set
            {
                if (_capacity < 0 && _capacity > 45)
                {
                    throw new CapacityOutOfRangeException(Constants.InvalidCapacityMessage);
                }
                _capacity = value;
            }
        }
        public Smg()
        {
            Kind = "Smg";
            CurrentBulletCount = Capacity;
            CreatedDate = DateTime.Now;
        }
        public Smg(string name, Bullet bulletType) :base(name, bulletType)
        {
        }
        public override string GetInfo()
        {
            return $"{Id}.{Kind}|{Name} - is a handheld lightweight machine gun, using {BulletType} cartridge";
        }
        public override string ToString()
        {
            return $"{Id}.{Kind}|{Name}";        
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
        public void BurstShoot()
        {
            if (CurrentBulletCount < 3)
            {
                Console.WriteLine(Constants.OutOfBulletMessage);
            }
            CurrentBulletCount -= 3;
        }
    }
}
