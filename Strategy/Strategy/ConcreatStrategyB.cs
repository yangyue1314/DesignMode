using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class ConcreatStrategyB: AbstractStrategy
    {
        public ConcreatStrategyB()
        {

        }

        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法B实现");
        }
    }
}
