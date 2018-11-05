using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class ChicagoStyleCheesePizza:Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            name = "chicago style pizza";
            dough = "extra thin crust dough";
            sauce = "plum tomato sauce";
        }

        public override void Cut()
        {
            Console.WriteLine("ChicagoStyleCheesePizza cut");
        }
    }
}
