using System;
using ConceptDemo.Contracts;

namespace EventsAndDelegates
{
    public class DelegatesDemo : IConceptDemo
    {
        public void ShowDemo()
        {
            // Creating Delegate Example Class Object
            var delegateExample = new DelegateExampleClass();
            
            // Delegate Overriding or Assignment
            delegateExample.TestDelegateObj = TestMethod;
            Console.WriteLine("\nDelegate Overriding or Assignment => delegateExample.TestDelegateObj = DelegatesDemo.TestMethod");
            Console.WriteLine("Delegate Invocation => delegateExample.TestDelegateObj()");
            delegateExample.TestDelegateObj();

            // Delegate Registering
            delegateExample.TestDelegateObj += TestMethod2;
            Console.WriteLine("\nDelegate Registering => delegateExample.TestDelegateObj += DelegatesDemo.TestMethod2");

            // Delegate Invocation
            Console.WriteLine("Delegate Invocation => delegateExample.TestDelegateObj()");
            delegateExample.TestDelegateObj();

            // Parametrised Delegate Invocation
            Console.WriteLine("\nPrametrised Delegate Invocation => delegateExample.ParametrisedTestDelegateObj(parameter)");
            delegateExample.ParametrisedTestDelegateObj("Invoking from ShowDemo");

            // Delegate Invocation with return value
            Console.WriteLine("Delegate Invocation with return value => var result = delegateExample.TestDelegateWithReturnValueObj()");
            var result = delegateExample.TestDelegateWithReturnValueObj();
            Console.WriteLine("Showing result return from delegate invocation : " + result);

            // Delegate Deregistering
            delegateExample.TestDelegateObj -= TestMethod2;
            Console.WriteLine("\nDelegate Deregistering => delegateExample.TestDelegateObj -= TestMethod2");
            Console.WriteLine("Delegate Invocation => delegateExample.TestDelegateObj()");
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