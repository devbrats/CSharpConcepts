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
            Console.WriteLine("\nEvent Registered => eventsExample.TestEvent += TestMethod");

            //Event Invocation
            eventsExample.RaiseTestEvent();
            eventsExample.RaiseParametrisedTestEvent("Raise Parametrised Event => eventsExample.RaiseParametrisedTestEvent");

            //Event Overriding Not allowed
            //eventsExample.TestEvent = TestMethod2();
            eventsExample.TestEvent += TestMethod2;
            Console.WriteLine("Event Registered => eventsExample.TestEvent += TestMethod2");

            //Event Invocation
            eventsExample.RaiseTestEvent();

            //Event Deregistering
            eventsExample.TestEvent -= TestMethod;
            Console.WriteLine("\nEvent DeRegistered => eventsExample.TestEvent -= TestMethod");

            //Event Invocation
            eventsExample.RaiseTestEvent();
        }

        private void TestMethod()
        {
            Console.WriteLine(this + ": Inside Test Method of EventsDemo Class.");
        }

        private void TestMethod2()
        {
            Console.WriteLine(this + ": Inside Test Method 2 of EventsDemo Class.");
        }
    }
}