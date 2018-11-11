using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class HasQuarterState:State
    {
        Random random = new Random();

        GumballMachine gumballMachine;
        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("no gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("quarter return");
            gumballMachine.SetState(gumballMachine.noQuarterState);
        }

        public void InsertQuarter()
        {
            Console.WriteLine("you cant insert another quarter");
            
        }

        public void TumCrank()
        {
            Console.WriteLine("you turned....");

            int winner = random.Next(10);
            Console.WriteLine(winner);
            if (winner >= 5 & gumballMachine.count > 1)
            {
                gumballMachine.SetState(gumballMachine.winnerState);
            }
            else
            {
                gumballMachine.SetState(gumballMachine.soldState);
            }
        }
    }
}
