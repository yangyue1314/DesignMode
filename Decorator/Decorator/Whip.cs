using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Whip: CondimentDecorator
    {

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
            price = 0.1f;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", whip";
        }
    }
}
