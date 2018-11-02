using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();

            Console.WriteLine("------------------------------");

            Duck modelDuck = new ModelDuck();
            modelDuck.PerformFly();
            modelDuck.SetFlyBehavior(new FlyWithWings());
            modelDuck.PerformFly();
        }
    }
}
