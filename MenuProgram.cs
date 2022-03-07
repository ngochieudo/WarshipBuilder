using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarshipBuilder
{
    public abstract class MenuProgram
    {
        protected const int QUIT = 0;
        public void Run()
        {
            bool running = true;
            while(running)
            {
                PrintMenu();
                int choice = GetChoice();
                DoTask(choice);
                if (choice == QUIT) running = false;
            }
        }
        protected abstract void PrintMenu();
        protected abstract void DoTask(int choice);

        protected virtual int GetChoice()
        {
            System.Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        protected virtual void ShowError()
        {
            System.Console.WriteLine("Invalid choice! Please choose again");
        }
    }
}