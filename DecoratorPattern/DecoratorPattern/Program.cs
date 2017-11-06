using System;

namespace DecoratorPattern
{
    class MainCoffee
    {
        static void Main()
        {
            Beverage beverage = new DarkRoast();
            beverage = new Mocha(beverage);
            beverage = new Soy(beverage);
            Console.Write(beverage.GetDescription() + " $" + beverage.Cost());
            Console.ReadKey();
        }
    }
}
