using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class WinnerState:State
    {
        GumballMachine gumballMachine;
        public WinnerState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("you are winner ,you get two gumballs");

            gumballMachine.ReleaseBall();
            if (gumballMachine.count == 0)
            {
                gumballMachine.SetState(gumballMachine.soldOutState);
            }
            else
            {
                gumballMachine.ReleaseBall();
                Console.WriteLine("out of gumballs");
                gumballMachine.SetState(gumballMachine.soldOutState);
                if (gumballMachine.count > 0)
                {
                    gumballMachine.SetState(gumballMachine.noQuarterState);
                }
                else
                {
                    Console.WriteLine("out of gumballs");
                    gumballMachine.SetState(gumballMachine.soldOutState);

                }
            }
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
