using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    interface State
    {
        void InsertQuarter();
        void EjectQuarter();
        void TumCrank();
        void Dispense();
    }
}
