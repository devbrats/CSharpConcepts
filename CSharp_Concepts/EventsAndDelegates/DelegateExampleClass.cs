using System;

namespace EventsAndDelegates
{
    // Delegate Definition
    public delegate void TestDelegate();

    public delegate void ParametrisedTestDelegate(string input);

    public delegate string TestDelegateWithReturnValue();

    public class DelegateExampleClass
    {
        // Delegate Instantiation
        public TestDelegate TestDelegateObj;
        public ParametrisedTestDelegate ParametrisedTestDelegateObj;
        public TestDelegateWithReturnValue TestDelegateWithReturnValueObj;

        public DelegateExampleClass()
        {
            // Delegate Registering
            TestDelegateObj += Method1;
            ParametrisedTestDelegateObj += ParametrisedMethod1;
            TestDelegateWithReturnValueObj += Method3;
            TestDelegateObj += Method2;
            // += is used to assign multiple methods to a single delgate making it as multicast delegate.
        }

        public void Method1()
        {
            Console.WriteLine("**********");
            Console.WriteLine(this+"\nInside Method 1.");
            Console.WriteLine("**********\n");
        }

        public void Method2()
        {
            Console.WriteLine("**********");
            Console.WriteLine(this+"\nInside Method 2.");
            Console.WriteLine("**********\n");
        }

        public string Method3()
        {
            return this+"Inside Method 3.";
        }

        public void ParametrisedMethod1(string input)
        {
            Console.WriteLine("**********");
            Console.WriteLine(this + "\nInside parametrised Method 1.");
            Console.WriteLine("Input Value : " + input);
            Console.WriteLine("**********\n");
        }
    }
}