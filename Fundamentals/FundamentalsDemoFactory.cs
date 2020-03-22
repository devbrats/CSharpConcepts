using System;
using ConceptDemo.Contracts;

namespace Fundamentals
{
    public class FundamentalsDemoFactory: IDemoFactory
    {
        public IConceptDemo GetDemo()
        {
            ShowDemoOptions();
            int demoChoice = int.Parse(Console.ReadLine());

            switch (demoChoice)
            {
                case 1:
                    return new DifferenceBetweenStringAndStringBuilder();
                case 2:
                    return new DifferenceBetweenOutAndRef();
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
            Console.Write("Please enter your choice for fundamentals demo type : ");
        }
    }
}