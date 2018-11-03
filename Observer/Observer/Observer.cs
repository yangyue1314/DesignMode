using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface Observer
    {
        void Update(float temperature, float humidity, float pressure);
    }
}
