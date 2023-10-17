using BuilderAssignment.Builders;
using BuilderAssignment.Models;
using System.Runtime.CompilerServices;

namespace BuilderAssignment
{
    public class RamenChef
    {
       
        public RamenBowl PrepareRamen(IRamenBuilder builder)
        {

            //TODO#1: Call each builder step declared in RamenBuilder class

            builder.BuildBroth();
            builder.BuildNoodles();
            builder.BuildToppings();
            builder.BuildExtras();

            return builder.GetRamen(); //TODO#2: Finaly return build bowl of ramen
        }

    }
}
