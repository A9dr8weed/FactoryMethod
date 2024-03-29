﻿using System;

namespace FactoryMethod
{
    public static class Program
    {
        private static void Main()
        {
            ClientCode();
        }

        public static void ClientCode()
        {
            GuitarFactory guitarFactory = null;

            Console.WriteLine("Enter the guitar type you want: ");
            string guitar = Console.ReadLine();

            switch (guitar.ToLower())
            {
                case "Cort":
                    guitarFactory = new ElectricGuitarFactory("Cort", 4000);
                    break;
                case "Fender":
                    guitarFactory = new AcousticGuitarFactory("Fender", 5000);
                    break;
            }

            Console.WriteLine(guitarFactory.CreateGuitar());
        }
    }
}