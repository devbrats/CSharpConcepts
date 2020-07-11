using System;
using ConceptDemo.Contracts;

namespace EventsAndDelegates
{
    public class DelegatesDemo : IConceptDemo
    {
        public void ShowDemo()
        {
            var delegateExample = new DelegateExampleClass();
            
            //Delegate Invocation
            delegateExample.TestDelegateObj();
            delegateExample.ParametrisedTestDelegateObj("Invoking from ShowDemo");
            var result = delegateExample.TestDelegateWithReturnValueObj();
            Console.WriteLine("Showing result return from delegate invocation : "+result);

            //Delegate Overriding
            delegateExample.TestDelegateObj = TestMethod;
            delegateExample.TestDelegateObj();
        }

        private void TestMethod()
        {
            Console.WriteLine("Inside Test Method of DelegatesDemo Class.");
        }
    }
}