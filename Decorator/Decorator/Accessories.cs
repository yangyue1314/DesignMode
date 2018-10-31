using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    //具体装饰类
    class Accessories:Decorator
    {
        public Accessories(Phone phone):base(phone)
        {

        }

        public override void Print()
        {
            base.Print();
            AddAccessories();
        }

        //新特性
        public void AddAccessories()
        {
            Console.WriteLine("手机挂件");
        }
    }
}
