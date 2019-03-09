using System;
using System.Collections.Generic;
using System.Text;

namespace FavThings.Breads
{
    class White: Bread
    {
        public White(MoistureLevel moisture, TextureType texture) : base(moisture, "White", texture)
        {
        }
    }
}
