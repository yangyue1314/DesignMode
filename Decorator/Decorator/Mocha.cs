using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Mocha:CondimentDecorator
    {
        

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            price = 0.2f;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", mocha";
        }

        
    }
}
