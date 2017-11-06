﻿using System;
namespace DecoratorPattern
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage) { this.beverage = beverage; }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }
        public override double Cost() { return .15 + beverage.Cost(); }
    }

}
