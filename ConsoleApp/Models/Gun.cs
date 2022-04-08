using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Models
{
    internal class Gun : Base
    {
        private static int _capacity;
        public int _currentBulletCount;

        public int Capacity { get; set; }
        public int CurrentBulletCount { get; set; }
        public Bullet BulletType { get; set; }
        static Gun()
        {
            
        }
        public Gun(string name, string kind) : base(name, kind)
        {
            Capacity = _capacity;
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
