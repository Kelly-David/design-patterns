﻿using System;
namespace DecoratorPattern
{
    public class DarkRoast : Beverage
    {
        public override double Cost() { return .99; }
        public override string GetDescription()
        {
            return "Dark Roast Coffee";
        }
    }

}
