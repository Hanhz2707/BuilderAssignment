using BuilderAssignment.Models;

namespace BuilderAssignment.Builders
{
    public class VeganRamenBuilder : IRamenBuilder
    {
        public RamenBowl ramen = new RamenBowl();

        public void BuildBroth()
        {
            ramen.Broth = BrothType.Vegan;
        }

        public void BuildNoodles()
        {
            ramen.Noodle = NoodleType.Soba;
        }

        public void BuildToppings()
        {
            ramen.Toppings.Add(Topping.BambooShoots);
            ramen.Toppings.Add(Topping.Seaweed);

        }

        public void BuildExtras()
        {
            
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}
