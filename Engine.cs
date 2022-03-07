using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarshipBuilder
{
    public class Engine
    {
        
        private string brand;
        private int hp;
        private int capacity;
        
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public Engine(string brand, int hp, int capacity)
        {
            
            Brand = brand;
            Hp = hp;
            Capacity = capacity;
        }
        public override string ToString()
        {
            return "Engine stats:  Brand: " + Brand + ", Horsepower: " + Hp + " hp, Capacity: " + Capacity;
        }
    }
}