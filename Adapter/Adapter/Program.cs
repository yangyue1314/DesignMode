using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();
            WildTurkey wildTurkey = new WildTurkey();
            Duck turkeyAdapter = new TurkeyAdapter(wildTurkey);

            turkeyAdapter.Fly();
            turkeyAdapter.Quack();
        }
    }
}
