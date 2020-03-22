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
                    demoFactory = demoHandler.GetDemoFactory();
                    if (demoFactory == null)
                    {
                        Console.WriteLine("Selected demo not available");
                        return;
                    }
                }
               
                var demo = demoFactory?.GetDemo();
                if (demo == null)
                {
                    Console.WriteLine("Selected demo not available");
                    return;
                }
                demo.ShowDemo();

                Console.WriteLine("********************************");
                Console.WriteLine("\nOptions:");
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
