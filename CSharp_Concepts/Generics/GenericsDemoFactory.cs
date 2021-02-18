using ConceptDemo.Contracts;

namespace Generics
{
    public class GenericsDemoFactory : IDemoFactory
    {
        public IConceptDemo SelectDemo()
        {
            return new GenericsDemo();
        }
    }
}
