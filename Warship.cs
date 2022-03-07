using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarshipBuilder
{
    public class Warship
    {
        protected Hull shipHull;
        protected Maingun shipMaingun;
        protected Torpedo shipTorpedo;
        protected Engine shipEngine;

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
        public override string ToString()
        {
            return ShipHull + "\n" + ShipMaingun + "\n" + ShipTorpedo + "\n" + ShipEngine; 
        }

    }
}