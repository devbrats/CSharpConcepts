using System;

namespace EventsAndDelegates
{
    public class EventExampleClass
    {
        //Defining an event
        /*
         By adding event keyword before any delegate we restrict the delegate from modification(overriding) from any other place. using the add and remove keywords similar like get and set for the properties.
         */

        public event TestDelegate TestEvent;

        public event ParametrisedTestDelegate ParametrisedTestEvent;

        public EventExampleClass()
        {
            TestEvent += Method1;
            ParametrisedTestEvent += Method1;
        }

        public void RaiseTestEvent()
        {
            Console.WriteLine("**********");
            Console.WriteLine("Raising TestEvent");
            TestEvent?.Invoke();
            Console.WriteLine("**********");
        }

        public void RaiseParametrisedTestEvent(string input)
        {
            Console.WriteLine("**********");
            Console.WriteLine("Raising Parametrised TestEvent");
            ParametrisedTestEvent?.Invoke(input);
            Console.WriteLine("**********");
        }

        private void Method1()
        {
            Console.WriteLine(this+"\nInside Method 1.");
        }

        public void Method1(string input)
        {
            Console.WriteLine(this + "\nInside parametrised Method 1.");
            Console.WriteLine("Input Value : " + input);
        }

    }
}