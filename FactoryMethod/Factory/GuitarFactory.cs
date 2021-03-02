namespace FactoryMethod
{
    /// <summary>
    /// The 'Creator' Abstract Class.
    /// </summary>
    public abstract class GuitarFactory
    {
        /// <summary>
        /// Factory method.
        /// </summary>
        /// <returns> Creates new objects. </returns>
        public abstract IGuitar GetGuitar();
    }
}