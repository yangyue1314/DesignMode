using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class ConcreteClassA:AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("具体类A 方法1实现");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("具体类A 方法2实现");
        }
    }
}
