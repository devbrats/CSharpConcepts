namespace EventsAndDelegates
{
    /// <summary>
    /// Factory which decides what type of demo for delegates need to be show
    /// </summary>
    public class DemoFactory
    {
        public static Demo GetDemo(string demoType)
        {
            if (demoType.Equals("DD"))
            {
                return new DelegateDemo();
            }

            return  new BuiltInDelegatesDemo();
        }
    }
}
