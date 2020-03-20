using System;
using EventsAndDelegates;

namespace ConceptDemo.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var demoHandler =new CSharpDemoHandler();
            var demoFactory = demoHandler.GetDemoFactory();
            if (demoFactory == null)
            {
                Console.WriteLine("Selected demo not available");
                return;
            }
            var demo = demoFactory.GetDemo();
            if (demo== null)
            {
                Console.WriteLine("Selected demo not available");
                return;
            }
            demo.ShowDemo();
        }
    }
}
