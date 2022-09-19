using System;

namespace FactoryMethod
{
    /// <summary>
    /// A 'ConcreteProduct' - Electric guitar class.
    /// </summary>
    public class ElectricGuitar : IGuitar
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public ElectricGuitar(string name, int price)
        {
            Console.Write("Electric guitar constructor: ");
            Name = name;
            Price = price;
        }

        public override string ToString() => $"{Name} with price {Price}.";
    }
}