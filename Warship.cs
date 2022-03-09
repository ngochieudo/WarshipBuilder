using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarshipBuilder
{
    public class Warship
    {
        public string Name { get; set; }
        private Hull shipHull;
        private Maingun shipMaingun;
        private Torpedo shipTorpedo;
        private Engine shipEngine;

        // public string Name
        // {
        //     get { return name; }
        //     set { name = value; }
        // }
        public Hull ShipHull
        {
            get { return shipHull; }
            set { shipHull = value; }
        }
        public Maingun ShipMaingun
        {
            get { return shipMaingun; }
            set { shipMaingun = value; }
        }
        public Torpedo ShipTorpedo
        {
            get { return shipTorpedo; }
            set { shipTorpedo = value; }
        }
        public Engine ShipEngine
        {
            get { return shipEngine; }
            set { shipEngine = value; }
        }
        public Warship()
        {

        }
        
        
        public override string ToString()
        {
            return Name + "\n" + ShipHull + "\n" + ShipMaingun + "\n" + ShipTorpedo + "\n" + ShipEngine; 
        }

    }
}