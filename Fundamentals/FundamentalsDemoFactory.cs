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
                    return new DifferenceBetweenStringAndStringBuilder();
                case 2:
                    return new DifferenceBetweenOutAndRef();
                case 3:
                    return new DifferenceBetweenPassingReferenceTypeUsingRefKeywordAndWithoutRef();
                case 4:
                    return new CollectionsInCSharp();
                default:
                    return null;
            }
        }

        private void ShowDemoOptions()
        {
            Console.WriteLine("\n"+Utility.LineSeprator);
            Console.WriteLine("Fundamentals Demo: ");
            Console.WriteLine("1. Difference between string and stringbuilder");
            Console.WriteLine("2. Difference between 'out' and 'ref'");
            Console.WriteLine("3. Difference between passing reference type value with or without using 'ref' keyword");
            Console.WriteLine("4. Collections in CSharp");
            Console.Write("Please enter your choice for fundamentals demo type : ");
        }
    }
}