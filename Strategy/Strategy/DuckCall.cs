using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class DuckCall
    {
        public Duck duck;

        public DuckCall()
        {
            duck = new ModelDuck();
            duck.PerformQuack();
            duck.SetQuackBehavior(new QuackOne());
            duck.PerformQuack();
        }
    }
}
