using System;

namespace Generics
{
    public class GenericTest<T> 
    {
        public GenericTest()
        {
            GenericProperty = default(T);
        }

        public GenericTest(T value)
        {
            GenericProperty = value;
        }

        public T GenericProperty { get; set; }

        public void Test(T value)
        {
            Console.WriteLine("Value : " + value);
            Console.WriteLine("Type : " + typeof(T));
        }

        public T Result()
        {
            return default(T);
        }
    }
}
