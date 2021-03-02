using System;

namespace FactoryMethod
{
    /// <summary>
    /// A 'ConcreteProduct' - Electric guitar class.
    /// </summary>
    public class ElectricGuitar : IGuitar
    {
        private string _name;
        private int _price;

        public ElectricGuitar(string name, int price)
        {
            Console.Write("Electric guitar constructor: ");
            _name = name;
            _price = price;
        }

        public string Name { get => _name; set => _name = value; }
        public int Price { get => _price; set => _price = value; }

        public override string ToString() => $"{Name} with price {Price}.";
    }
}