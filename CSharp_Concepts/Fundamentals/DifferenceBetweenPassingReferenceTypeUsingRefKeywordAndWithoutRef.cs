using System;
using ConceptDemo.Contracts;

namespace Fundamentals
{
    public class DifferenceBetweenPassingReferenceTypeUsingRefKeywordAndWithoutRef : IConceptDemo
    {
        class TestObject
        {
            public string TestProperty { get; set; }
        }

        public void ShowDemo()
        {
            AnalyzeUsingRefKeyword();
            AnalyzeWithoutUsingRefKeyword();
        }

        private void AnalyzeUsingRefKeyword()
        {
            Console.WriteLine("\n"+Utility.LineSeprator);
            Console.WriteLine("Passing reference type value using ref keyword analysis");

            var testObject = new TestObject()
            {
                TestProperty = "First time initialized"
            };

            Console.WriteLine("\nObject Hashcode: " + testObject.GetHashCode());
            Console.WriteLine("TestObject property value: " + testObject.TestProperty);
            Console.WriteLine("Calling MethodWithRefKeywordForPropertyUpdation...");

            MethodWithRefKeywordForPropertyUpdation(ref testObject);

            Console.WriteLine("\nObject Hashcode: " + testObject.GetHashCode());
            Console.WriteLine("TestObject property value: "+testObject.TestProperty);
            Console.WriteLine("Calling MethodWithRefKeywordForObjectUpdation...");

            MethodWithRefKeywordForObjectUpdation(ref testObject);

            Console.WriteLine("\nObject Hashcode: " + testObject.GetHashCode());
            Console.WriteLine("TestObject property value: " + testObject.TestProperty);
            Console.WriteLine("\nUsing 'ref' keyword with reference type values we can assign a new object to the reference.");
            Console.WriteLine(Utility.LineSeprator);
        }

        private void AnalyzeWithoutUsingRefKeyword()
        {
            Console.WriteLine("\n" + Utility.LineSeprator);
            Console.WriteLine("Passing reference type value without using ref keyword analysis");

            var testObject = new TestObject()
            {
                TestProperty = "First time initialized"
            };

            Console.WriteLine("\nObject Hashcode: " + testObject.GetHashCode());
            Console.WriteLine("TestObject property value: " + testObject.TestProperty);
            Console.WriteLine("Calling MethodWithoutRefKeywordForPropertyUpdation...");

            MethodWithoutRefKeywordForPropertyUpdation(testObject);

            Console.WriteLine("\nObject Hashcode: " + testObject.GetHashCode());
            Console.WriteLine("TestObject property value: " + testObject.TestProperty);
            Console.WriteLine("Calling MethodWithoutRefKeywordForObjectUpdation...");

            MethodWithoutRefKeywordForObjectUpdation(testObject);

            Console.WriteLine("\nObject Hashcode: "+testObject.GetHashCode());
            Console.WriteLine("TestObject property value: " + testObject.TestProperty);
            Console.WriteLine("\nWithout using 'ref' keyword reference type can't be re initialized to new instance, only properties can be modified");
            Console.WriteLine(Utility.LineSeprator);
        }

        private void MethodWithRefKeywordForPropertyUpdation(ref TestObject testObject)
        {
            testObject.TestProperty = "Assigned in MethodWithRefKeywordForPropertyUpdation";
        }

        private void MethodWithoutRefKeywordForPropertyUpdation(TestObject testObject)
        {
            testObject.TestProperty = "Assigned in MethodWithoutRefKeywordForPropertyUpdation";
        }

        private void MethodWithRefKeywordForObjectUpdation(ref TestObject testObject)
        {
            testObject = new TestObject()
            {
                TestProperty = "New initialisation inside MethodWithRefKeywordForPropertyUpdation"
            };
        }

        private void MethodWithoutRefKeywordForObjectUpdation(TestObject testObject)
        {
            testObject = new TestObject()
            {
                TestProperty = "New initialisation inside MethodWithoutRefKeywordForPropertyUpdation"
            };
        }



    }
}