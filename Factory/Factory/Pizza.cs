using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    abstract class Pizza
    {
        public string name;
        public string dough;
        public string sauce;

        public virtual void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough.. " + dough);
            Console.WriteLine("Adding sauce " + sauce);

        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cut");
        }

        public virtual void Box()
        {
            Console.WriteLine("Box");
        }
    }
}
