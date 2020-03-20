using ConceptDemo.Contracts;
using EventsAndDelegates;
using System;

namespace ConceptDemo.UI
{
    public class CSharpDemoHandler : AbstractDemoHandler
    {
        public override IDemoFactory GetDemoFactory()
        {
            ShowDemoOptions();
            var demoChoice = int.Parse(Console.ReadLine());
            switch (demoChoice)
            {
                case 1:
                    return new DelegateDemoFactory();
                case 2:
                    return null;
                default:
                    return null;
            }
        }

        private void ShowDemoOptions()
        {
            Console.WriteLine("Demo Type:");
            Console.WriteLine("1.Events and Delegate");
            Console.WriteLine("2.");
            Console.Write("Please Enter your choice for the demo type : ");
        }
    }
}