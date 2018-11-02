using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class ConcreteClassB:AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("具体类B 方法1实现");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("具体类B 方法2实现");
        }
    }
}
