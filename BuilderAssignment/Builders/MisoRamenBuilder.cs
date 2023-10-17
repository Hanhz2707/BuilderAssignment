using BuilderAssignment.Models;

namespace BuilderAssignment.Builders
{
    public class MisoRamenBuilder : IRamenBuilder
    {
        public RamenBowl ramen = new RamenBowl();

        public void BuildBroth()
        {
            ramen.Broth = BrothType.Miso;
        }

        public void BuildNoodles()
        {
            ramen.Noodle = NoodleType.Udon;
        }

        public void BuildToppings()
        {
            ramen.Toppings.Add(Topping.GreenOnions);
        }

        public void BuildExtras()
        {
            ramen.Extras.Add(Extra.Corn);
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}