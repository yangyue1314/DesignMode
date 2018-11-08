using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Light
    {
        public void LightOn()
        {
            Console.WriteLine("light on");
        }

        public void LightOff()
        {
            Console.WriteLine("light off");
        }
    }
}
