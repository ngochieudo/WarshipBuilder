using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarshipBuilder
{
    public class Hull
    {
        private double length;
        private double width;
        private int armor;
        private int displacement;

        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public double Width
        {
            get { return width; }
            set { length = value; }
        }
        public int Armor
        {
            get { return armor; }
            set { armor = value; }
        }
        public int Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }
        public Hull(double length, double width, int armor, int displacement)
        {
            Length = length;
            Width = width; 
            Armor = armor; 
            Displacement = displacement;
        }
        public override string ToString()
        {
            return "Length: " + Length + "m" + ", Width: " + Width + "m," + " Armor: " + Armor + " mm" + ", Displacement: " + Displacement + " tons";
        }
    }
}