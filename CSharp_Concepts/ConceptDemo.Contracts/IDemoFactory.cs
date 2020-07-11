namespace ConceptDemo.Contracts
{
    /// <summary>
    /// Interface to define contract for a demo factory
    /// </summary>
    public interface  IDemoFactory
    {
        /// <summary>
        /// Method to select demo from the available demos in the demo factory
        /// </summary>
        /// <returns></returns>
        IConceptDemo SelectDemo();
    }
}