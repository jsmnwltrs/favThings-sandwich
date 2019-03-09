using FavThings.Sandwiches;
using System;
using System.Collections.Generic;
using System.Text;

namespace FavThings.Veggies
{
    abstract class Veggie
    {
        public string Name { get; set; }
        public VeggieColor Color { get; set; }
        
        protected Veggie(string name, VeggieColor color)
        {
            Color = color;
            Name = name;
        }

        public virtual void OrderVeggie(Veggie veggie)
        {
            Console.WriteLine($"{veggie.Color} {veggie.Name}");
        }
    }

    internal enum VeggieColor
    {
        Green,
        Red,
        Orange,
        Purple,
        Blue,
        White
    }
}
