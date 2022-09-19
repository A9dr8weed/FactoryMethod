using System;

namespace FactoryMethod
{
    /// <summary>
    /// A 'ConcreteProduct' - Acoustic guitar class.
    /// </summary>
    public class AcousticGuitar : IGuitar
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public AcousticGuitar(string name, int price)
        {
            Console.Write("Acoustic guitar constructor: ");
            Name = name;
            Price = price;
        }

        public override string ToString() => $"{Name} with price {Price}.";
    }
}