using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarshipBuilder
{
    public class Torpedo
    {
        private int amount;
        private int speed;
        private int caliber;
        private int range;

        public int Amount
        {
            get { return amount; }
            set { amount = value;}
        }
        public int Caliber
        {
            get { return caliber; }
            set { caliber = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Range 
        {
            get { return range; }
            set { range = value; }
        }
        public Torpedo(int amount, int caliber, int speed, int range)
        {
            Amount = amount;
            Caliber = caliber;
            Speed = speed;
            Range = range;
        }
        public override string ToString()
        {
            return "Torpedo amount: " + Amount + ", Caliber: " + Caliber + "mm, Speed: " + Speed + "knt, Range: " + Range + "km";
        }
    }
}