using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light();
            Projector projector = new Projector();
            Facade facade = new Facade(projector,light);
            facade.WatchMovie();
            facade.CloseMovie();
        }
    }
}
