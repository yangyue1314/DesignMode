using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class OperationDiv:Operation
    {
        public override float GetResult()
        {
            if(NumberB==0)
            {
                throw new Exception("除数不能为0!!!");
            }
            result = NumberA / NumberB;
            return result;
        }
    }
}
