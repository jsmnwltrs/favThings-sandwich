using FavThings.Sandwiches;
using System;
using System.Collections.Generic;
using System.Text;

namespace FavThings.Meats
{
    abstract class Meat
    {
        public string Name { get; set; }
        public MeatTexture Texture { get; set; }
        public MeatCut Cut { get; set; }

        protected Meat(string name, MeatTexture texture, MeatCut cut)
        {
            Name = name;
            Texture = texture;
            Cut = cut;
        }

        public virtual void OrderMeat(Meat meat)
        {
            Console.WriteLine($"I would like to order a {meat.Texture} {meat.Name} sandwich with {meat.Cut} slices.");
        }
    }

    internal enum MeatCut
    {
        Shredded,
        Thin,
        Thick
    }

    internal enum MeatTexture
    {
        Juicy,
        Tender,
        Dry,
        Chewy,
        Goopy,
        Tough
    }
}
