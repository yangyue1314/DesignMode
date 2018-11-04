using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription() + " $ " + beverage.Cost());

            beverage = new Mocha(beverage);
            Console.WriteLine(beverage.GetDescription() + " $ " + beverage.Cost());

            beverage = new Mocha(beverage);
            Console.WriteLine(beverage.GetDescription() + " $ " + beverage.Cost());

            beverage = new Whip(beverage);
            Console.WriteLine(beverage.GetDescription() + " $ " + beverage.Cost());

            beverage.size = Size.Larger;
            Console.WriteLine(beverage.GetDescription() + " $ " + beverage.Cost());

            beverage.size = Size.Middle;
            Console.WriteLine(beverage.GetDescription() + " $ " + beverage.Cost());

            beverage.size = Size.Small;
            Console.WriteLine(beverage.GetDescription() + " $ " + beverage.Cost());

        }
    }
}
