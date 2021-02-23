namespace FactoryMethod
{
    /// <summary>
    /// `Product` - Common interface for all specific classes.
    /// </summary>
    public interface IGuitar
    {
        /// <summary>
        /// Guitar name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The price of a guitar.
        /// </summary>
        int Price { get; set; }
    }
}