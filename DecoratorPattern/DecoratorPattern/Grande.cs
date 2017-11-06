using System;
namespace DecoratorPattern
{
    public class Grande : CondimentDecorator
    {
        public Grande(Beverage beverage) { this.beverage = beverage; }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Grande";
        }
        public override double Cost() { return .15 + beverage.Cost(); }
    }

}
