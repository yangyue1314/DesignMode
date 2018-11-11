using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class LeafElement:DrawingElement
    {
        public LeafElement(string name):base(name)
        {

        }

        public override void Add(DrawingElement drawingElement)
        {
            Console.WriteLine("cant add to a leaf");
        }

        public override void Display(int index)
        {
            Console.WriteLine(new String('-', index) + "+ " + name);
        }

        public override void Remove(DrawingElement drawingElement)
        {

            Console.WriteLine("cant remove from a leaf");
        }
    }
}
