using System;

namespace FactoryMethod
{
    /// <summary>
    /// A 'ConcreteCreator' - Acoustic guitar class.
    /// </summary>
    public class AcousticGuitarFactory : GuitarFactory
    {
        private readonly string _name;
        private readonly int _price;

        public AcousticGuitarFactory(string name, int price)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _price = price;
        }

        /// <summary>
        /// Overridden base class method that returns an object.
        /// </summary>
        /// <returns> New acoustic guitar object. </returns>
        public override IGuitar CreateGuitar()
        {
            return new AcousticGuitar(_name, _price);
        }
    }
}