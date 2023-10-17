using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Models
{
    /// <summary>
    /// This class represents the final bowl of ramen
    /// It should have attributes like broth, type of noodle, toppings and extras
    /// </summary>
    public class RamenBowl
    {
        //TODO#1: Add attributes for each enum in IngredientEnums.cs file
        public BrothType Broth { get; set; }
        public NoodleType Noodle { get; set; }
        public List<Topping> Toppings = new List<Topping>();
        public List<Extra> Extras = new List<Extra>();

        //TODO#2: Return description of finished bowl of ramen
        public string FinishedBowlOfRamen()
        {
            // Create a string with the desired format
            return $"- Ramen Bowl{Environment.NewLine}" +
                   $"  Recipe:{Environment.NewLine}" +
                   $"  - Broth: {Broth}{Environment.NewLine}" +
                   $"  - Noodles: {Noodle}{Environment.NewLine}" +
                   $"  - Toppings: {string.Join(", ", Toppings)}{Environment.NewLine}" +
                   $"  - Extras: {string.Join(", ", Extras)}{Environment.NewLine}";
        }

    }
}
