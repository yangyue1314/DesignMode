using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class ConcreatStrategyA: AbstractStrategy
    {
        public ConcreatStrategyA()
        {

        }

        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法A实现");
        }
    }
}
