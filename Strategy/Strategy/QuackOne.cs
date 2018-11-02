using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class QuackOne:QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("第一种叫声");
        }
    }
}
