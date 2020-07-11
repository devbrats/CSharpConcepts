using System;
using ConceptDemo.Contracts;

namespace ConceptDemo.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            IDemoFactory demoFactory=null;
            int choice = 1;
            while (choice == 1||choice==2)
            {
                if (choice == 1)
                {
                    var demoHandler = new CSharpDemoHandler();
                    demoFactory = demoHandler.SelectDemoFactory();
                    if (demoFactory == null)
                    {
                        Console.WriteLine("Selected demo not available");
                        return;
                    }
                }
               Console.Clear();
                var demo = demoFactory?.SelectDemo();
                if (demo == null)
                {
                    Console.WriteLine("Selected demo not available");
                    return;
                }

                Console.Clear();
                demo.ShowDemo();

                Console.WriteLine("\n"+Utility.LineSeprator);
                Console.WriteLine("Options:");
                Console.WriteLine("1. Go To Main Menu.");
                Console.WriteLine("2. Go To Sub Menu.");
                Console.Write("Please select your choice: ");
                choice = int.Parse(Console.ReadLine());
                if (choice != 1 && choice != 2)
                {
                    break;
                }
                Console.Clear();
            }

        }
    }
}
