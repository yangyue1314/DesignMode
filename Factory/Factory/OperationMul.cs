using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class OperationMul:Operation
    {
        public override float GetResult()
        {
            result = NumberA * NumberB;
            return result;
        }
    }
}
