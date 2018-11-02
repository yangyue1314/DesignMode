using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class ModelDuck:Duck
    {
        public ModelDuck()
        {
            quackBehavior = new QuackTwo();
            flyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("i am a modelduck");
        }
    }
}
