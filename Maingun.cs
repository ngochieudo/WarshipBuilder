using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarshipBuilder
{
    public class Maingun
    {
        private int caliber;
        private double range; 
        private int rate;
        public int Caliber
        {
            get { return caliber; }
            set { caliber = value; }
        }
        public double Range
        {
            get { return range; }
            set { range = value; }
        }
        public int Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        public Maingun(int caliber, double range, int rate)
        {
            Caliber = caliber;
            Range = range;
            Rate = rate; 

        }
        public override string ToString()
        {
            return "Caliber: " + Caliber + "mm, Range: " + Range + "km, Rate of fire: " + Rate + " shells/min";
        }
    }
}