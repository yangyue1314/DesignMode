using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class MallardDuck :Duck
    {
        public MallardDuck()
        {
            quackBehavior = new QuackOne();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("QuackOne----FlyWithWings");
        }
    }
}
