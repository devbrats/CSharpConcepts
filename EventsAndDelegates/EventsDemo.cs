using System;
using ConceptDemo.Contracts;

namespace EventsAndDelegates
{
    public class EventsDemo : IConceptDemo
    {
        public void ShowDemo()
        {
            var eventsExample = new EventExampleClass();
            eventsExample.TestEvent += TestMethod;

            //Event Invocation
            eventsExample.RaiseTestEvent();
            eventsExample.RaiseParametrisedTestEvent("Invoking from Events Demo Class");

            //Event Overriding Not allowed
            //eventsExample.TestEvent = TestMethod();
            eventsExample.TestEvent += TestMethod;
        }

        private void TestMethod()
        {
            Console.WriteLine(this + "Inside Test Method of DelegatesDemo Class.");
        }
    }
}