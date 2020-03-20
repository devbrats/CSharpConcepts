using System;

namespace EventsAndDelegates
{
    /// <summary>
    /// Class contain methods which we used to show demo for delegates
    /// </summary>
    public class MethodsRepository
    {
        public static void Display()
        {
            Console.WriteLine("Display() Method is Called......");
        }

        public static void DisplayValues(int x)
        {
            Console.WriteLine("Display Values: " + x);
        }

        public static Delegate1 GetDisplayMethod()
        {
            return Display;
        }

        public static void InvokeDelegate(Delegate1 del)
        {
            del.Invoke();
        }

        public static void TestDisplay()
        {
            Console.WriteLine("TestDisplay() Method is Called......");
        }

        public static void ReTestDisplay()
        {
            Console.WriteLine("ReTestDisplay Method is Called......");
        }
    }
}