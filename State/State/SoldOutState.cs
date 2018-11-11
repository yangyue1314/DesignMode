using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class SoldOutState:State
    {
        GumballMachine gumballMachine;
        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            
            Console.WriteLine("no gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("you cant eject quarter,you has not insert quarter");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("you cant insert quarter ,the gumballmachine has soldout");

        }

        public void TumCrank()
        {
            Console.WriteLine("you turned,but there no gumball");

        }
    }
}
