using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class GumballMachine
    {
        public State soldOutState;
        public State noQuarterState;
        public State hasQuarterState;
        public State soldState;
        public State winnerState;

        public State state;
        public int count = 0;

        public GumballMachine(int count)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);

            if(count>0)
            {
                state = noQuarterState;
                this.count = count;
            }
        }

        public void InsertQuarter()
        {
            state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            state.EjectQuarter();
        }

        public void TumCrank()
        {
            state.TumCrank();
            state.Dispense();
        }

        public void SetState(State state)
        {
            this.state = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("a gumball rolling out the slot");
            if(count!=0)
            {
                count -= 1;
            }
        }

        public void Refill(int count)
        {
            if(count>0)
            {
                this.count = count;
                state = noQuarterState;
            }
        }
    }
}
