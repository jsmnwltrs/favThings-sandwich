using FavThings.Breads;
using FavThings.Condiments;
using FavThings.Meats;
using FavThings.Veggies;

namespace FavThings.Sandwiches
{
    class Sandwich
    {
        public Bread Bread { get; set; }
        public Meat Meat { get; set; }
        public Veggie Veggie { get; set; }
        public Condiment Condiment { get; set; }

        public Sandwich(Bread bread, Meat meat, Veggie veggie, Condiment condiment)
        {
            Bread = bread;
            Meat = meat;
            Veggie = veggie;
            Condiment = condiment;
        }

        public void OrderSandwich()
        {
            Meat.OrderMeat(Meat);
            Bread.OrderBread(Bread);
            Veggie.OrderVeggie(Veggie);
            Condiment.OrderCondiment(Condiment);
        }
    }
}
