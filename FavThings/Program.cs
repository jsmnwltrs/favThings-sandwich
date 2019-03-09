using FavThings.Breads;
using FavThings.Condiments;
using FavThings.Sandwiches;
using FavThings.Veggies;
using System;

namespace FavThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var myTomato = new Tomato(VeggieColor.Red);
            var mySourdough = new Sourdough(MoistureLevel.Moist, TextureType.Fluffy);
            var myChicken = new Chicken(Meats.MeatTexture.Tender, Meats.MeatCut.Shredded);
            var myMayo = new Mayo(FlavorType.Creamy, AmountType.Extra);

            var mySandwich = new Sandwich(mySourdough, myChicken, myTomato, myMayo);

            mySandwich.OrderSandwich();

            Console.ReadLine();
        }
    }
}
