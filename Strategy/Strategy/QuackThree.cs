using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class QuackThree:QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("第三种叫声");
        }
    }
}
