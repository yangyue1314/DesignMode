using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    interface Command
    {
        void Execute();
        void Undo();
    }
}
