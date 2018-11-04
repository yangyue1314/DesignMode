using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Espresso:Beverage
    {
        public Espresso()
        {
            description = "Espresso";
            price = 1.89f;
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
