using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    //抽象装饰类
    abstract class Decorator:Phone
    {
        private Phone phone;

        public Decorator(Phone phone)
        {
            this.phone = phone;
        }

        public override void Print()
        {
            if(phone!=null)
            {
                phone.Print();
            }
        }
    }
}
