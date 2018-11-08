using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Projector
    {
        public void ProjectorOn()
        {
            Console.WriteLine("projector on");
        }

        public void ProjectorOff()
        {
            Console.WriteLine("projector off");
        }

        public void ProjectorSetSize()
        {
            Console.WriteLine("projector set size");
        }
    }
}
