using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    //具体组件类
    class ApplePhone:Phone
    {
        public override void Print()
        {
            Console.WriteLine("开始执行具体的对象-苹果手机");
        }
    }
}
