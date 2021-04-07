using System;
using ConceptDemo.Contracts;

namespace ConceptDemo.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            CSharpDemoHandler demoHandler = new CSharpDemoHandler();
            IDemoFactory demoFactory=null;
            string navigationText ;
            int choice = 1;

            do
            {
                navigationText = $"{demoHandler}>";
                Console.Clear();
                if (choice == 1)
                {
                    demoFactory = demoHandler.SelectDemoFactory();
                    if (demoFactory == null)
                    {
                        Console.WriteLine("Selected demo not available");
                        return;
                    }
                }

                Console.Clear();
                navigationText += $"{demoFactory}>";
                Console.WriteLine(navigationText);

                IConceptDemo demo = demoFactory?.SelectDemo();

                if (demo == null)
                {
                    Console.WriteLine("Selected demo not available");
                    return;
                }

                Console.Clear();
                navigationText += $"{demo}>";
                Console.WriteLine(navigationText);

                demo.ShowDemo();

                Console.WriteLine("\n" + Utility.LineSeprator);
                Console.WriteLine("Options:");
                Console.WriteLine("1. Go To Main Menu.");
                Console.WriteLine("2. Go To Sub Menu.");
                Console.Write("Please select your choice: ");
                choice = int.Parse(Console.ReadLine());

            }
            while (choice == 1 || choice == 2);
            Console.WriteLine("Wrong Choice !.");

        }
    }
}
