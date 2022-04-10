using System;
using System.Collections.Generic;
using ConsoleApp.Interfaces;
using System.Text;

namespace ConsoleApp.Models
{
    internal class Gun : Base
    {
        protected int _capacity;
        public virtual int Capacity
        {
            get { return _capacity; }
            set
            {
                if (_capacity < 0 && value > _capacity)
                {
                    throw new IndexOutOfRangeException();
                } 
            } 
        }
        public int CurrentBulletCount { get; set; }
        protected Bullet BulletType { get; set; }
        public Gun()
        {
            CreatedDate = DateTime.Now;
        }
        public Gun(string name, Bullet bulletType ) : base(name)
        {
            CurrentBulletCount = Capacity;
            BulletType = bulletType;
        }
        public override string ToString()
        {
            return $"{Id}.{Kind}|{Name}";
        }
        /// <summary>
        /// Reloads weapon
        /// </summary>
        public void Reload()
        {
            CurrentBulletCount = Capacity;
        }
    }
}
