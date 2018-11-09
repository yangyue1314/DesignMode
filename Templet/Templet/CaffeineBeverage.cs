using System;
using System.Collections.Generic;
using System.Text;

namespace Templet
{
    abstract class CaffeineBeverage
    {
        public void Prepare()
        {
            BoilWater();
            Brew();
            AddCondition();
            PourInCup();
        }

        public void BoilWater()
        {
            Console.WriteLine("boil water");
        }

        public void PourInCup()
        {
            Console.WriteLine("pour in cup");
        }

        public abstract void Brew();

        public abstract void AddCondition();
    }
}
