using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarshipBuilder
{
    public abstract class WarshipBuilder
    {
        public abstract void Build(Warship ws);
    }
    public class HullBuilder : WarshipBuilder
    {
        public override void Build(Warship ws)
        {
            System.Console.WriteLine("-------Build ship hull-------");

            System.Console.Write("Input hull length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Input hull width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Input armor thickness: ");
            int armor = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Input ship displacement: ");
            int displacement = Convert.ToInt32(Console.ReadLine());

            Hull h = new Hull(length, width, armor, displacement);
            ws.ShipHull = h;
        }
    }
    public class MaingunBuilder : WarshipBuilder
    {
        public override void Build(Warship ws)
        {
            System.Console.WriteLine("-------Build ship maingun-------");

            System.Console.Write("Input caliber: ");
            int caliber = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Input gun range: ");
            int range = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter amount of turret: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Gun setup: ");
            string setup = Console.ReadLine();
            Maingun mg = new Maingun(caliber, range, amount, setup);
            ws.ShipMaingun = mg;
        }
    }
    public class TorpedoBuilder : WarshipBuilder
    {
        public override void Build(Warship ws)
        {
            System.Console.WriteLine("-------Build torpedo for ship-------");
            System.Console.WriteLine("Enter torpedo amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            if(amount <= 0)
            {
                System.Console.WriteLine("No torpedo installed! ");
            }
            else
            {
            System.Console.Write("Input caliber: ");
            int caliber = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Input torpedo speed: ");
            int speed = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Input torpedo range: ");
            int range = Convert.ToInt32(Console.ReadLine());
            Torpedo t = new Torpedo(amount, caliber, speed, range);
            ws.ShipTorpedo = t;
            }
            
            
        }
    }
    public class EngineBuilder : WarshipBuilder
    {
        public override void Build(Warship ws)
        {
            System.Console.WriteLine("Build ship engine");
            
            System.Console.Write("Input engine brand: ");
            string brand = Console.ReadLine();
            System.Console.WriteLine("Input enigne horsepower: ");
            int hp = Convert.ToInt32(Console.ReadLine());

            Engine e = new Engine(brand, hp);
            ws.ShipEngine = e;
        }
    }
}