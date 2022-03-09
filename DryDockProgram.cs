using System.Net.WebSockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarshipBuilder
{
    public class DryDockProgram : MenuProgram
    {
        private HullBuilder hull;
        private MaingunBuilder maingun;
        private TorpedoBuilder torpedo;
        private EngineBuilder engine;
        private List<Warship> warships;
        Warship ws = new Warship();
        
        public DryDockProgram()
        {
            hull = new HullBuilder();
            maingun = new MaingunBuilder();
            torpedo = new TorpedoBuilder();
            engine = new EngineBuilder();
            warships = new List<Warship>(); 
        }
        protected override void PrintMenu()
        {
            System.Console.WriteLine("Ship building program!");
            System.Console.WriteLine("1. Build new ship");
            System.Console.WriteLine("2. Show all ship");
            System.Console.WriteLine("3. Delete ship");
            System.Console.WriteLine("0. Quit program");
        }
        protected override void DoTask(int choice)
        {
            switch(choice)
            {
                case 1: BuildWarship(); break; 
                case 2: ShowAllShips(); break;
                case 3: DeleteShip(); break;
                case 0: break;
                default: ShowError(); break;
            }
        }
        public void BuildWarship()
        {
            System.Console.WriteLine(" Building ship ");
            
            
            System.Console.Write("Enter ship name: ");
            string name = Console.ReadLine();
            hull.Build(ws);
            maingun.Build(ws);
            torpedo.Build(ws);
            engine.Build(ws);

            warships.Add(ws);
            System.Console.WriteLine("Add successful!");
            ws.ToString();
            
            
            
            
        }
        public void ShowAllShips()
        {
            foreach(Warship ws in warships)
            {
                ws.ToString();
            }
        }
        public void DeleteShip()
        {
            System.Console.Write("Enter the ship name you want to delete: ");
            string name = Console.ReadLine();
            foreach(Warship ws in warships)
            {
                if(ws.Name.Contains(name)) 
                {
                warships.Remove(ws);
                System.Console.WriteLine("Ship deleted! ");
                }
                else System.Console.WriteLine("No ship contains the name! ");

            }
        }
    }
}