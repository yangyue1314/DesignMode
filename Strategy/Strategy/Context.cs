using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Context
    {
        AbstractStrategy strategy = null;

        public Context(string type)
        {
            switch (type)
            {
                case "正常收费":
                    ConcreatStrategyA concreatStrategyA = new ConcreatStrategyA();
                    this.strategy = concreatStrategyA;
                    break;
                case "打8折":
                    ConcreatStrategyB concreatStrategyB = new ConcreatStrategyB();
                    this.strategy = concreatStrategyB;
                    break;
                default:
                    Console.WriteLine("没有此算法");
                    break;
            }
        }


        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}
