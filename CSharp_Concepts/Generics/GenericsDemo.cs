using System;
using ConceptDemo.Contracts;

namespace Generics
{
    public class GenericsDemo : IConceptDemo
    {
        public void ShowDemo()
        {
            StringTest();
            IntTest();
        }

        private void StringTest()
        {
            string testString = "String Test";
            Console.WriteLine(testString);
            var stringTest = new GenericTest<string>();
            stringTest.Test(testString);
            var result = stringTest.Result();
            Console.WriteLine("Result : " + result);
        }

        private void IntTest()
        {
            Console.WriteLine("\nInteger Test");
            int testInt = 10;
            var intTest = new GenericTest<int>();
            intTest.Test(testInt);
            var result = intTest.Result();
            Console.WriteLine("Result : " + result);
        }
    }
}
