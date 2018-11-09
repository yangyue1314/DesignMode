using System;
using System.Collections.Generic;
using System.Text;

namespace Templet
{
    class Caffe : CaffeineBeverage
    {
        public override void AddCondition()
        {
            Console.WriteLine("add caffe");
        }

        public override void Brew()
        {
            Console.WriteLine("caffe brew");
        }
    }
}
