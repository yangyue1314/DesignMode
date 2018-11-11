using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine(5);

            gumballMachine.InsertQuarter();
            gumballMachine.TumCrank();

            gumballMachine.InsertQuarter();
            gumballMachine.TumCrank();

            gumballMachine.InsertQuarter();
            gumballMachine.TumCrank();

            gumballMachine.InsertQuarter();
            gumballMachine.TumCrank();

            gumballMachine.InsertQuarter();
            gumballMachine.TumCrank();
        }
    }
}
