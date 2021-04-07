using System;
using ConceptDemo.Contracts;

namespace Fundamentals
{
    public class FundamentalsDemoFactory: IDemoFactory
    {
        public IConceptDemo SelectDemo()
        {
            ShowDemoOptions();
            int demoChoice = int.Parse(Console.ReadLine());

            switch (demoChoice)
            {
                case 1:
                    return new StringAndStringBuilder();
                case 2:
                    return new OutAndRef();
                case 3:
                    return new PassingByReferenceUsingRefOrWithoutRefKeyword();
                case 4:
                    return new Collections();
                default:
                    return null;
            }
        }

        private void ShowDemoOptions()
        {
            Console.WriteLine("\n"+Utility.LineSeprator);
            Console.WriteLine("Fundamentals Demo: ");
            Console.WriteLine("1. String and Stringbuilder");
            Console.WriteLine("2. 'out' and 'ref'");
            Console.WriteLine("3. Passing reference type value with or without using 'ref' keyword");
            Console.WriteLine("4. Collections in CSharp");
            Console.Write("Please enter your choice for fundamentals demo type : ");
        }
    }
}