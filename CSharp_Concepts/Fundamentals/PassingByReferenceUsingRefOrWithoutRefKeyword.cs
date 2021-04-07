using System;
using ConceptDemo.Contracts;

namespace Fundamentals
{
    public class PassingByReferenceUsingRefOrWithoutRefKeyword : IConceptDemo
    {
        public void ShowDemo()
        {
            Analysis();
        }

        private void Analysis()
        {
            Console.WriteLine("\n"+Utility.LineSeprator);

            var testObject = new Test()
            {
                TestProperty = "First time initialized"
            };

            Console.WriteLine("Object Hashcode: " + testObject.GetHashCode());
            Console.WriteLine("TestObject property value: " + testObject.TestProperty);

            Console.WriteLine("Calling MethodWithoutRefKeywordForPropertyUpdation(testObject)\n{");

            MethodWithoutRefKeywordForPropertyUpdation(testObject);

            Console.WriteLine("Object Hashcode: " + testObject.GetHashCode());
            Console.WriteLine("TestObject property value: " + testObject.TestProperty + "\n}");

            Console.WriteLine("\nCalling MethodWithRefKeywordForPropertyUpdation(ref testObject)\n{");

            MethodWithRefKeywordForPropertyUpdation(ref testObject);

            Console.WriteLine("Object Hashcode: " + testObject.GetHashCode());
            Console.WriteLine("TestObject property value: "+testObject.TestProperty+"\n}");

            Console.WriteLine("\nCalling MethodWithoutRefKeywordForObjectUpdation(testObject)\n{");

            MethodWithoutRefKeywordForObjectUpdation(testObject);

            Console.WriteLine("Object Hashcode: " + testObject.GetHashCode());
            Console.WriteLine("TestObject property value: " + testObject.TestProperty + "\n}");

            Console.WriteLine("\nCalling MethodWithoutRefKeywordForObjectUpdation(ref testObject)\n{");

            MethodWithRefKeywordForObjectUpdation(ref testObject);

            Console.WriteLine("Object Hashcode: " + testObject.GetHashCode());
            Console.WriteLine("TestObject property value: " + testObject.TestProperty + "\n}");
            Console.WriteLine("\nUsing 'ref' keyword with reference type values we can assign a new object to the reference.");
            Console.WriteLine(Utility.LineSeprator);
        }

        private void MethodWithRefKeywordForPropertyUpdation(ref Test test)
        {
            test.TestProperty = "Assigned in MethodWithRefKeywordForPropertyUpdation";
        }

        private void MethodWithoutRefKeywordForPropertyUpdation(Test test)
        {
            test.TestProperty = "Assigned in MethodWithoutRefKeywordForPropertyUpdation";
        }

        private void MethodWithRefKeywordForObjectUpdation(ref Test test)
        {
            test = new Test()
            {
                TestProperty = "New initialisation inside MethodWithRefKeywordForObjectUpdation"
            };
        }

        private void MethodWithoutRefKeywordForObjectUpdation(Test test)
        {
            test = new Test()
            {
                TestProperty = "New initialisation inside MethodWithoutRefKeywordForObjectUpdation"
            };
        }
    }

    public class Test
    {
        public string TestProperty { get; set; }
    }

}