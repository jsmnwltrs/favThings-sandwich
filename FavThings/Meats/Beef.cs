using FavThings.Meats;
using System;
using System.Collections.Generic;
using System.Text;

namespace FavThings
{
    class Beef : Meat
    {
        public Beef(MeatTexture texture, MeatCut cut) : base("Beef", texture, cut)
        {
        }
    }
}
