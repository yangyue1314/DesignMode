using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            CompositeElement root = new CompositeElement("Picture");
            root.Add(new LeafElement("Red Line"));
            root.Add(new LeafElement("Blue Circle"));
            root.Add(new LeafElement("Green Box"));


            CompositeElement comp = new CompositeElement("Two Circles");
            comp.Add(new LeafElement("Black Circle"));
            comp.Add(new LeafElement("White Circle"));
            root.Add(comp);


            LeafElement pe = new LeafElement("Yellow Line");
            root.Add(pe);
            root.Remove(pe);

            root.Display(1);
        }
    }
}
