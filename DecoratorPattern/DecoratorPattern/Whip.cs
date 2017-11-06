using System;
namespace DecoratorPattern
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage) { this.beverage = beverage; }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }
        public override double Cost() { return .55 + beverage.Cost(); }
    }

}
