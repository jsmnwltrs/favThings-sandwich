using System;
using System.Collections.Generic;
using System.Text;

namespace FavThings.Condiments
{
    class Mustard : Condiment
    {
        public Mustard(FlavorType flavor, AmountType amount) : base(flavor, "Mustard", amount)
        {
        }
    }
}
