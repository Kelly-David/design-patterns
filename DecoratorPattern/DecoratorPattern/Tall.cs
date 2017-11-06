using System;
namespace DecoratorPattern
{
    public class Tall : CondimentDecorator
    {
        public Tall(Beverage beverage) { this.beverage = beverage; }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Tall";
        }
        public override double Cost() { return 0 + beverage.Cost(); }
    }

}
