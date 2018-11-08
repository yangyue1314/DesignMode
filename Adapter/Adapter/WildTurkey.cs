using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class WildTurkey : Turkey
    {
        public void Fly()
        {
            Console.WriteLine("wildturkey fly 1/5");
        }

        public void Gobble()
        {
            Console.WriteLine("wildturkey quack");
        }
    }
}
