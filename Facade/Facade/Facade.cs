using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Facade
    {
        Projector projector;
        Light light;

        public Facade(Projector projector, Light light)
        {
            this.projector = projector;
            this.light = light;
        }

        public void WatchMovie()
        {
            light.LightOn();
            projector.ProjectorOn();
            projector.ProjectorSetSize();
        }

        public void CloseMovie()
        {
            projector.ProjectorOff();
            light.LightOff();

        }
    }
}
