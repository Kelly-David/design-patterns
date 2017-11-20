using System;
namespace FactoryMethodPattern
{
    public class NYPizzaStore : PizzaStore
    {
        public Pizza CreatePizza(String type)
        {

            if (type.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else if (type.Equals("veggie"))
            {
                return new NYStyleVeggiePizza();
            }
            else if (type.Equals("clam"))
            {
                return new NYStyleClamPizza();
            }
            else if (type.Equals("pepperoni"))
            {
                return new NYStylePepperoniPizza();
            }
            else return null;
        }

        public NYPizzaStore()
        {
        }
    }
}
