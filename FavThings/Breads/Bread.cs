using FavThings.Sandwiches;
using System;
using System.Collections.Generic;
using System.Text;

namespace FavThings.Breads
{
    abstract class Bread
    {
        public MoistureLevel Moisture { get; set; }
        public string Name { get; set; }
        public TextureType Texture { get; set; }

        protected Bread(MoistureLevel moisture, string name, TextureType texture)
        {
            Moisture = moisture;
            Name = name;
            Texture = texture;
        }

        public virtual void OrderBread(Bread bread)
        {
            Console.WriteLine($"I would also like it to have {bread.Moisture} {bread.Texture} {bread.Name} bread, ");
        }
    }

    internal enum MoistureLevel
    {
        Wet,
        Moist,
        Dry
    }

    internal enum TextureType
    {
        Soft,
        Crunchy,
        Hard,
        Fluffy
    }
}
