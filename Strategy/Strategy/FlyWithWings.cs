using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class FlyWithWings :FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("i am fly");
        }
    }
}
