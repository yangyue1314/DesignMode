using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class FlyNoWay:FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("i cant fly");
        }
    }
}
