using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class HouseBlend:Beverage
    {
        public HouseBlend()
        {
            description = "house blend coffee";
            price = 0.9f;
        }

        public override float Cost()
        {
            return UpdatePriceBySize(size);
        }

        public override string GetDescription()
        {
            return description;
        }



    }
}
