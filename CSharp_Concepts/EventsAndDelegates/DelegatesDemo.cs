using System;
using ConceptDemo.Contracts;

namespace EventsAndDelegates
{
    public class DelegatesDemo : IConceptDemo
    {
        public void ShowDemo()
        {
            Console.WriteLine("DelegatesDemo");

            // Creating Delegate Example Class Object
            var delegateExample = new DelegateExampleClass();
            
            // Delegate Overriding or Assignment
            delegateExample.TestDelegateObj = TestMethod;
            Console.WriteLine("\nTestMethod is assigned to delegateExample.TestDelegateObj");
            Console.WriteLine("delegateExample.TestDelegateObj is invoking.");
            delegateExample.TestDelegateObj();

            // Delegate Registering
            delegateExample.TestDelegateObj += TestMethod2;
            Console.WriteLine("\nTestMethod2 is registered for delegateExample.TestDelegateObj");

            // Delegate Invocation
            Console.WriteLine("delegateExample.TestDelegateObj is invoking.");
            delegateExample.TestDelegateObj();
            Console.WriteLine("delegateExample.ParametrisedTestDelegateObj is invoking.");
            delegateExample.ParametrisedTestDelegateObj("Invoking from ShowDemo");

            // Delegate Invocation with return value
            Console.WriteLine("delegateExample.TestDelegateWithReturnValueObj is invoking.");
            var result = delegateExample.TestDelegateWithReturnValueObj();
            Console.WriteLine("Showing result return from delegate invocation : " + result);

            // Delegate Deregistering
            delegateExample.TestDelegateObj -= TestMethod2;
            Console.WriteLine("\nTestMethod2 is deregistered for delegateExample.TestDelegateObj");
            Console.WriteLine("delegateExample.TestDelegateObj is invoking.");
            delegateExample.TestDelegateObj();

        }

        private void TestMethod()
        {
            Console.WriteLine("Inside Test Method of DelegatesDemo Class.");
        }

        private void TestMethod2()
        {
            Console.WriteLine("Inside Test Method 2 of DelegatesDemo Class.");
        }
    }
}