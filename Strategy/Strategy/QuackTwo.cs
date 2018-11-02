using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class QuackTwo:QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("第二种叫声");
        }
    }
}
