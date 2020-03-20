using System;

namespace EventsAndDelegates
{
    //Define Delegate
    public delegate void Delegate1();
    public delegate void Delegate2(int x);
    /// <summary>
    /// Delegate Demo
    /// </summary>
    public class DelegateDemo:Demo
    {
        public override void ShowDemo()
        {
            //Declare and Instantiation
            Delegate1 delegate1 = MethodsRepository.Display;

            //Invoke
            delegate1.Invoke();

            Console.WriteLine("---------------------");

            //Add
            delegate1 += MethodsRepository.TestDisplay;

            //Invoke
            delegate1.Invoke();

            Console.WriteLine("---------------------");

            //Remove
            delegate1 -= MethodsRepository.Display;
            delegate1.Invoke();

            Console.WriteLine("---------------------");


            //Calling method with parameter using delegate
            Delegate2 delegate2 = MethodsRepository.DisplayValues;
            delegate2.Invoke(8);

            Console.WriteLine("---------------------");

            //Reinstantiate and Invoke
            delegate1 = MethodsRepository.ReTestDisplay;
            delegate1.Invoke();

            Console.WriteLine("---------------------");

            //Return a Delegate
            var del = MethodsRepository.GetDisplayMethod();
            del.Invoke();

            Console.WriteLine("---------------------");

            //Pass delegate as parameter
            MethodsRepository.InvokeDelegate(delegate1);
        }

     
    }
}