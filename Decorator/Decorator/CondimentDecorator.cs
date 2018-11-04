using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    abstract class CondimentDecorator:Beverage
    {
        protected Beverage beverage;
        public override string GetDescription() { return description; }

        public override float Cost()
        {
            return UpdatePriceBySize(size);
        }

        public override float UpdatePriceBySize(Size size)
        {
            if (beverage != null)
            {
                return base.UpdatePriceBySize(size) + beverage.UpdatePriceBySize(size);
            }
            return base.UpdatePriceBySize(size);
        }
    }
}
