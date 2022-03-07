using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarshipBuilder
{
    public class Torpedo
    {
        private int caliber;
        private int speed;
        private int range;
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
        public Torpedo(int caliber, int speed, int range)
        {
            Caliber = caliber;
            Speed = speed;
            Range = range;
        }
        public override string ToString()
        {
            return "Caliber: " + Caliber + "mm, Speed: " + Speed + "knt, Range: " + Range + "km";
        }
    }
}