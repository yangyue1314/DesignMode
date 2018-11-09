using System;
using System.Collections.Generic;
using System.Text;

namespace Templet
{
    class Tea : CaffeineBeverage
    {
        public override void AddCondition()
        {
            Console.WriteLine("add tea");
        }

        public override void Brew()
        {
            Console.WriteLine("tea brew");
        }
    }
}
