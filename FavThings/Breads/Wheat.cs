using System;
using System.Collections.Generic;
using System.Text;

namespace FavThings.Breads
{
    class Wheat : Bread
    {
        public Wheat(MoistureLevel moisture, TextureType texture) : base(moisture, "Wheat", texture)
        {
        }
    }
}
