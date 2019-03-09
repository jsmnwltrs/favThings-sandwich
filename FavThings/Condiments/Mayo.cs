using System;
using System.Collections.Generic;
using System.Text;

namespace FavThings.Condiments
{
    class Mayo : Condiment
    {
        public Mayo(FlavorType flavor, AmountType amount) : base(flavor, "Mayo", amount)
        {
        }
    }
}
