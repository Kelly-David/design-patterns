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
            beverage = new Whip(beverage);
            Console.WriteLine(beverage.GetDescription());
            Console.WriteLine("Total: $" + beverage.Cost());
            Console.ReadKey();
        }
    }
}
