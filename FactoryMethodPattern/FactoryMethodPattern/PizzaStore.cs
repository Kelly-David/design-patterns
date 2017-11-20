using System;
namespace FactoryMethodPattern
{
    public abstract class PizzaStore
    {
        protected abstract Pizza CreatePizza(String item);

        public Pizza OrderPizza(String type)
        {
            Pizza pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}