using System;
using ConceptDemo.Contracts;

namespace EventsAndDelegates
{
    public class EventsDemo : IConceptDemo
    {
        public void ShowDemo()
        {
            Console.WriteLine("Events Demo");
            var eventsExample = new EventExampleClass();
            eventsExample.TestEvent += TestMethod;
            Console.WriteLine("\nTestMethod handler is registered to eventsExample.TestEvent");

            //Event Invocation
            eventsExample.RaiseTestEvent();
            eventsExample.RaiseParametrisedTestEvent("Invoking from Events Demo Class");

            //Event Overriding Not allowed
            //eventsExample.TestEvent = TestMethod2();
            eventsExample.TestEvent += TestMethod2;
            Console.WriteLine("TestMethod2 handler is registered to eventsExample.TestEvent");

            //Event Invocation
            eventsExample.RaiseTestEvent();

            //Event Deregistering
            eventsExample.TestEvent -= TestMethod;
            Console.WriteLine("\nTestMethod handler is deregistered to eventsExample.TestEvent");

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