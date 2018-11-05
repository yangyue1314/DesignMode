using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class NYStyleCheesePizza:Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "NY style pizza";
            dough= "thin crust dough";
            sauce = "marinara sauce";
        }
    }
}
