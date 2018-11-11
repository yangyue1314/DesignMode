using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class SoldState:State
    {
        GumballMachine gumballMachine;
        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            gumballMachine.ReleaseBall();
            if(gumballMachine.count>0)
            {
                gumballMachine.SetState(gumballMachine.noQuarterState);
            }
            else
            {
                Console.WriteLine("out of gumballs");
                gumballMachine.SetState(gumballMachine.soldOutState);

            }
            Console.WriteLine("no gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("sorry , you alredy turned the tumcrank");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("plase wait,we giving you a gumball");

        }

        public void TumCrank()
        {
            Console.WriteLine("you turned....");
            
        }
    }
}
