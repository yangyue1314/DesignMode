using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    //具体装饰类
    class Sticker:Decorator
    {
        public Sticker(Phone phone):base(phone)
        {

        }

        public override void Print()
        {
            base.Print();
            AddSticker();

        }

        //新特性
        public void AddSticker()
        {
            Console.WriteLine("手机贴膜");
        }
    }
}
