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
        private Warship ws = new Warship();
        
        public void DemoShip()
        {
            Warship demo = new Warship();
            demo.Name = "iowa";
            Hull h = new Hull(271, 40, 320, 57000);
            demo.ShipHull = h;
            Maingun mg = new Maingun(406, 40, 3, "3x3");
            demo.ShipMaingun = mg;
            Torpedo t = new Torpedo(2, 533, 60, 12);
            demo.ShipTorpedo = t;
            Engine e = new Engine("sdada", 100000);
            demo.ShipEngine = e;
            warships.Add(demo);
            System.Console.WriteLine("Demo ship Added! ");
        }
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
            System.Console.WriteLine("4. Edit ship");
            System.Console.WriteLine("5. Add debug ship");
            System.Console.WriteLine("0. Quit program");
        }
        protected override void DoTask(int choice)
        {
            switch(choice)
            {
                case 1: BuildWarship(); break; 
                case 2: ShowAllShips(); break;
                case 3: DeleteShip(); break;
                case 4: EditShip(); break;
                case 5: DemoShip(); break;
                case 0: break;
                default: ShowError(); break;
            }
        }
        public void BuildWarship()
        {
            System.Console.WriteLine(" Building ship ");
            
            
            System.Console.Write("Enter ship name: ");
            string name = Console.ReadLine();
            ws.Name = name;
            hull.Build(ws);
            maingun.Build(ws);
            torpedo.Build(ws);
            engine.Build(ws);

            warships.Add(ws);
            System.Console.WriteLine("Add successful!");
            System.Console.WriteLine(ws.ToString());
            
        }
        public void ShowAllShips()
        {
            foreach(Warship ws in warships)
            {
                System.Console.WriteLine(ws.ToString());
            }
        }
        public void DeleteShip()
        {
            System.Console.Write("Enter the ship name you want to delete: ");
            string name = Console.ReadLine();
            foreach(Warship ws in warships)
            {
                if(ws.Name.Contains(name) && ws != null) 
                {
                warships.Remove(ws);
                System.Console.WriteLine("Ship deleted! ");
                return;
                }
                else System.Console.WriteLine("No ship contains the name! ");
                return;

            }
        }
        public void EditShip()
        {
            System.Console.WriteLine("Enter ship name: ");
            string name = Console.ReadLine();
            if(name == "") {
                EditShip();
            }
            for(int i = 0; i < warships.Count; i++)
            {
                if(warships[i].Name.Contains(name))
                {
                    // iowa
                    // Length: 40m, Width: 0m, Armor: 320 mm, Displacement: 210000 tons
                    // Caliber: 406mm, Range: 40km, 
                    // Amount of turret: 9 shells/min, Setup: 3x3
                    System.Console.WriteLine("1. Edit name");
                    System.Console.WriteLine("2. Edit maingun");
                    System.Console.WriteLine("3. Edit hull");
                    System.Console.WriteLine("4. Edit torpedo");
                    System.Console.WriteLine("5. Edit engine");
                    System.Console.WriteLine("0. Back to main menu");
                    System.Console.WriteLine("Enter choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch(choice)
                    {
                        case 1: EditName(i); break; 
                        case 2: EditMaingun(i); break;
                        case 3: EditHull(i); break;
                        case 4: EditTorpedo(i); break;
                        case 5: EditEngine(i); break;
                        case 0: Run(); break;
                        

                    }
                }
                else 
                {   
                    System.Console.WriteLine("Ship name doesn't exist! ");
                    return;  
                }
            }
            
    
            
        }
        public void EditName(int i)
        {
            if(warships[i] != null)
            {
            System.Console.WriteLine("Enter new name("+ warships[i].Name + "): "  );
            string name = Console.ReadLine();
            warships[i].Name = name;
            System.Console.WriteLine("Updated successful! " + warships[i].Name);
            }
            else
            {
                System.Console.WriteLine("Warship doesn't exist!");
            }
            return;

        }
        public void EditMaingun(int i)
        {
            if(warships[i] != null)
            {
                System.Console.WriteLine("Enter new caliber: ");
                int caliber = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Enter new range: ");
                double range = Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine("Enter amount of turret: ");
                int amount = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Enter new setup: ");
                string setup = Console.ReadLine();
                Maingun mg = new Maingun(caliber, range, amount, setup);

                warships[i].ShipMaingun = mg;
                System.Console.WriteLine("Update successful! ");
            }
             else
            {
                System.Console.WriteLine("Warship doesn't exist!");
            }
        }
        public void EditHull(int i)
        {
            if(warships[i] != null)
            {
                System.Console.WriteLine("Enter new length: ");
                double length = Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine("Enter new width: ");
                double width = Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine("Enter new armor: ");
                int armor = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Enter new displacement: ");
                int displacement = Convert.ToInt32(Console.ReadLine());
                Hull h = new Hull(length, width, armor, displacement);

                warships[i].ShipHull= h;
                System.Console.WriteLine("Update successful! ");
            }
             else
            {
                System.Console.WriteLine("Warship doesn't exist!");
            }
        }
        public void EditTorpedo(int i)
        {
            if(warships[i] != null)
            {
                System.Console.WriteLine("Enter new range: ");
                int amount = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Enter new caliber");
                int caliber = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Enter new speed: ");
                int speed = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Enter new range: ");
                int range = Convert.ToInt32(Console.ReadLine());
                
                Torpedo t = new Torpedo(amount, caliber, speed, range);
                warships[i].ShipTorpedo = t;
            }
             else
            {
                System.Console.WriteLine("Warship doesn't exist!");
            }
        }
        public void EditEngine(int i)
        {
            if(warships[i] != null)
            {
                System.Console.WriteLine("Enter new brand: ");
                string brand = Console.ReadLine();
                System.Console.WriteLine("Enter horsepower: ");
                int hp = Convert.ToInt32(Console.ReadLine());

                Engine e = new Engine(brand, hp);
                warships[i].ShipEngine = e;
            }
             else
            {
                System.Console.WriteLine("Warship doesn't exist!");
            }
        }
    }
}