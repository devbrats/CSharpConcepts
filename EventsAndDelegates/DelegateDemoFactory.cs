using System;
using ConceptDemo.Contracts;

namespace EventsAndDelegates
{
    /// <summary>
    /// Factory which decides what type of demo for delegates need to be show
    /// </summary>
    public class DelegateDemoFactory:IDemoFactory
    {
        public  IConceptDemo GetDemo()
        {
            ShowDemoOptions();
            int demoChoice = int.Parse(Console.ReadLine());

            switch (demoChoice)
            {
                case 1:
                    return new DelegateDemo();
                case 2:
                    return new BuiltInDelegatesDemo();
                default:
                    return null;
            }
        }

        private void ShowDemoOptions()
        {
            Console.WriteLine("\n******************************************");
            Console.WriteLine("Events and Delegates Demo: ");
            Console.WriteLine("1.Delegate");
            Console.WriteLine("2.Built In Delegates") ;
            Console.Write("Please Enter your choice for the demo type : ");
        }
        
    }
}
