using System;
using ConceptDemo.Contracts;

namespace Fundamentals
{
    public class OutAndRef : IConceptDemo
    {
        public void ShowDemo()
        {
            AnalyzeOutKeyword();
            AnalyzeRefKeyword();
        }

        private void AnalyzeOutKeyword()
        {
            Console.WriteLine("\n"+Utility.LineSeprator);
            Console.WriteLine("'out' keyword analysis...\n");
            string inputString ;
            Console.WriteLine("Declaration => string inputString ;");
            Console.WriteLine("Using out keyword, parameter need not to be initialized before passing it to calling method.");
            Console.WriteLine("Calling MethodWithOutAsParameter(out inputString)");
            MethodWithOutAsParameter(out inputString);
            Console.WriteLine("Output Value: " + inputString);
            Console.WriteLine(Utility.LineSeprator);
        }

        private void AnalyzeRefKeyword()
        {
            Console.WriteLine("\n");
            Console.WriteLine(Utility.LineSeprator);
            Console.WriteLine("'ref' keyword analysis...\n");
            string inputString ;
            inputString = "Ref Analysis";
            Console.WriteLine("Declaration => string inputString = \"Ref Analysis\";");
            Console.WriteLine("Using ref keyword, parameter need to be initialized before passing it to calling method.");
            Console.WriteLine("Calling MethodWithRefAsParameter(ref inputString);");
            MethodWithRefAsParameter(ref inputString);
            Console.WriteLine("String Value: " + inputString);
            Console.WriteLine(Utility.LineSeprator);
        }

        private void MethodWithOutAsParameter(out string inputParameter)
        {
            Console.WriteLine("Inside MethodWithOutAsParameter()\n{");
            inputParameter = "Assigned in MethodWithOutAsParameter";
            Console.WriteLine("out variable should be assigned before returning from this method.\n}");
        }

        private void MethodWithRefAsParameter(ref string inputParameter)
        {
            Console.WriteLine("Inside MethodWithRefAsParameter()\n{");
            inputParameter = "Assigned in MethodWithRefAsParameter";
            Console.WriteLine("ref variable need not to be assigned before returning from this method.\n}");
        }
    }
}