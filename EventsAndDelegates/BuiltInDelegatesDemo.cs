using System;
using ConceptDemo.Contracts;

namespace EventsAndDelegates
{
    /// <summary>
    /// C# built in delegates(Action, Func, Predicate) demo
    /// </summary>
    public class BuiltInDelegatesDemo:IConceptDemo
    {
        private Action _displayAction;
        private Func<Delegate1> _funcGetDelegate;

        public void ShowDemo()
        {
            Console.WriteLine("Built in delegates demo:");

            _displayAction = MethodsRepository.Display;
            _displayAction.Invoke();

            _funcGetDelegate = MethodsRepository.GetDisplayMethod;
            var value = _funcGetDelegate.Invoke();
            value.Invoke();
        }
    }
}