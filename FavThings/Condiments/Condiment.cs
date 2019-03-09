using FavThings.Sandwiches;
using System;
using System.Collections.Generic;
using System.Text;

namespace FavThings.Condiments
{
    abstract class Condiment
    {
        public FlavorType Flavor { get; set; }
        public string Name { get; set; }
        public AmountType Amount { get; set; }

        protected Condiment(FlavorType flavor, string name, AmountType amount)
        {
            Flavor = flavor;
            Name = name;
            Amount = amount;
        }

        public virtual void OrderCondiment(Condiment condiment)
        {
            Console.WriteLine($"and {condiment.Amount} {condiment.Flavor} {condiment.Name}");
        }
    }

    internal enum FlavorType
    {
        Tangy,
        Sweet,
        Spicy,
        Salty,
        Creamy
    }

    internal enum AmountType
    {
        Extra,
        Some,
        Light
    }
}
