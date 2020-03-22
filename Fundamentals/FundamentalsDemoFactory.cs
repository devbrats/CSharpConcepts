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
                    return null;
                default:
                    return null;
            }
        }

        private void ShowDemoOptions()
        {
            Console.WriteLine("\n******************************************");
            Console.WriteLine("Fundamentals Demo: ");
            Console.WriteLine("1.Difference between string and stringbuilder");
            Console.WriteLine("2.Difference between 'out' and 'ref'");
            Console.Write("Please Enter your choice for the demo type : ");
        }
    }
}