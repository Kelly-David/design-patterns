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
            beverage = new Grande(beverage);
            Console.WriteLine(beverage.GetDescription());
            Console.WriteLine("Total: $" + beverage.Cost());
            Console.ReadKey();
        }
    }
}
