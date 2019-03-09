using System;
using System.Collections.Generic;
using System.Text;

namespace FavThings.Breads
{
    class Sourdough : Bread
    {
        public Sourdough(MoistureLevel moisture, TextureType texture) : base(moisture, "Sourdough", texture)
        { 
        }

    }
}
