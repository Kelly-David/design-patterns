using System;
namespace DecoratorPattern
{
    public class Venti : CondimentDecorator
    {
        public Venti(Beverage beverage) { this.beverage = beverage; }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Venti";
        }
        public override double Cost() { return (0.50 * beverage.Cost()) + beverage.Cost();}
    }

}
