using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class OperationFactory
    {
        public static Operation CreatOperate(string operate)
        {
            Operation operation = null;
            switch (operate)
            {
                case "+":
                    operation = new OperationAdd();
                    break;
                case "-":
                    operation = new OperationSub();
                    break;
                case "*":
                    operation = new OperationMul();
                    break;
                case "/":
                    operation = new OperationDiv();
                    break;
            }
            return operation;
        }
    }
}
