using System;
using System.Collections.Generic;
using System.Text;

namespace FavThings.Condiments
{
    class Ranch : Condiment
    {
        public Ranch(FlavorType flavor, AmountType amount) : base(flavor, "Ranch", amount)
        {
        }
    }
}
