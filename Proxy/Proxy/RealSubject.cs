using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class RealSubject:Subject
    {
        public override void Request()
        {
            Console.WriteLine("真实的请求");
        }
    }
}
