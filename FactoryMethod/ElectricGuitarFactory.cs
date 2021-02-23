using System;

namespace FactoryMethod
{
    /// <summary>
    /// A 'ConcreteCreator' - Electric guitar class.
    /// </summary>
    public class ElectricGuitarFactory : GuitarFactory
    {
        private readonly string _name;
        private readonly int _price;

        public ElectricGuitarFactory(string name, int price)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _price = price;
        }

        /// <summary>
        /// Overridden base class method that returns an object.
        /// </summary>
        /// <returns> New Electric guitar object. </returns>
        public override IGuitar GetGuitar()
        {
            return new ElectricGuitar(_name, _price);
        }
    }
}