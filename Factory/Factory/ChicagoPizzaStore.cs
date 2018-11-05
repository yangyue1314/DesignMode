using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class ChicagoPizzaStore:PizzaStore
    {
        public override Pizza CreatPizza(string type)
        {
            switch (type)
            {
                case "chicago":
                    return new ChicagoStyleCheesePizza();
                    //往后面加
            }
            return null;
        }
    }
}
