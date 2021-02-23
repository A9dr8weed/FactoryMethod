using System;

namespace FactoryMethod
{
    /// <summary>
    /// A 'ConcreteProduct' - Acoustic guitar class.
    /// </summary>
    public class AcousticGuitar : IGuitar
    {
        private string _name;
        private int _price;

        public AcousticGuitar(string name, int price)
        {
            Console.Write("Acoustic guitar constructor: ");
            _name = name;
            _price = price;
        }

        public string Name { get => _name; set => _name = value; }
        public int Price { get => _price; set => _price = value; }

        public override string ToString() => $"{Name} with price {Price}.";
    }
}