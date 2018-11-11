using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class CompositeElement:DrawingElement
    {
        private List<DrawingElement> elements =new List<DrawingElement>();


        public CompositeElement(string name): base(name)
        {

        }

        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }

        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }

        public override void Display(int index)
        {
            Console.WriteLine(new String('-', index) +"+ " + name);

            foreach (DrawingElement d in elements)
            {
                d.Display(index + 2);
            }
        }
    }
}
