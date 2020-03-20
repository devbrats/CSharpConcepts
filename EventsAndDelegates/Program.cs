using System;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegates demo:");
            Demo demo = DemoFactory.GetDemo("DD");
            demo.ShowDemo();

            Console.WriteLine("Built in delegates demo:");
            demo = DemoFactory.GetDemo("BID");
            demo.ShowDemo();
        }

    }
}
