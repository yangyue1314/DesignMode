using System;

/// <summary>
/// 代理模式就是真实对象的代表（并不认识认识真实对象，只认识代理）
/// </summary>
namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy();
            proxy.Request();
        }
    }
}
