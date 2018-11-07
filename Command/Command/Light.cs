using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class Light
    {
        public Light()
        {

        }

        public void Off()
        {
            Console.WriteLine("light off");
        }

        public void On()
        {
            Console.WriteLine("light on");
        }
    }
}
