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
            Warship ws = new Warship();

            hull.Build(ws);
            maingun.Build(ws);
            torpedo.Build(ws);
            engine.Build(ws);
            
            warships.Add(ws);
            System.Console.WriteLine("Add new ship successful!");
            
            
        }
        public void ShowAllShips()
        {
            foreach(Warship ws in warships)
            {

            }
        }
        public void DeleteShip()
        {
            
        }
    }
}