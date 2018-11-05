using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class NYPizzaStore:PizzaStore
    {
        public override Pizza CreatPizza(string type)
        {
            switch (type)
            {
                case "NY":
                    return new NYStyleCheesePizza();
                    //往后面加
            }
            return null;
        }
    }
}
