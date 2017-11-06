using System;
namespace DecoratorPattern
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;
    }

}
