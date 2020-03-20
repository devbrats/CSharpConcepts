using System;

namespace EventsAndDelegates
{
    /// <summary>
    /// C# built in delegates(Action, Func, Predicate) demo
    /// </summary>
    public class BuiltInDelegatesDemo:Demo
    {
        private Action _displayAction;
        private Func<Delegate1> _funcGetDelegate;

        public override void ShowDemo()
        {
            _displayAction = MethodsRepository.Display;
            _displayAction.Invoke();

            _funcGetDelegate = MethodsRepository.GetDisplayMethod;
            var value = _funcGetDelegate.Invoke();
            value.Invoke();
        }
    }
}