using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class MallardDuck : Duck
    {
        public void Fly()
        {
            Console.WriteLine("mallardduck fly");
        }

        public void Quack()
        {
            Console.WriteLine("mallardduck quack");
        }
    }
}
