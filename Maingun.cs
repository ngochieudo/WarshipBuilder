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
        private int amount;
        private string setup;
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
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public string Setup
        {
            get { return setup; }
            set { setup = value; }
        }
        public Maingun(int caliber, double range, int amount, string setup)
        {
            Caliber = caliber;
            Range = range;
            Amount = amount; 
            Setup = setup;

        }
        public override string ToString()
        {
            return "Caliber: " + Caliber + "mm, Range: " + Range + "km, Amount of turret: " + Amount + " shells/min, Setup: " + Setup;
        }
    }
}