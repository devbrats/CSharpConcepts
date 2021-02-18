using System;

namespace Generics
{
    public class GenericClass<T> 
    {
        public void ParametrisedMethod(T value)
        {
            Console.WriteLine("Value : " + value);
            Console.WriteLine("Type : " + typeof(T));
        }

        public T MethodWithReturnType()
        {
            return default(T);
        }
    }
}
