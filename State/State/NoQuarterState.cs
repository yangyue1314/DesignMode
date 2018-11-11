using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class NoQuarterState : State
    {
        GumballMachine gumballMachine;
        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("you need pay first");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("you has not insert a quarter");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("you insert a quarter");
            gumballMachine.SetState(gumballMachine.hasQuarterState);
        }

        public void TumCrank()
        {
            Console.WriteLine("you turned but there no quarter");
        }
    }
}
