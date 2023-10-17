using BuilderAssignment.Models;

namespace BuilderAssignment.Builders
{
    public class SpicyRamenBuilder : IRamenBuilder
    {
        public RamenBowl ramen = new RamenBowl();

        public void BuildBroth()
        {
            ramen.Broth = BrothType.SpicyTonkotsu ;
        }

        public void BuildNoodles()
        {
            ramen.Noodle = NoodleType.Thin;
        }

        public void BuildToppings()
        {
            ramen.Toppings.Add(Topping.ChashuPork);
            ramen.Toppings.Add(Topping.GreenOnions);
        }

        public void BuildExtras()
        {
            ramen.Extras.Add(Extra.ExtraSpice);
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}