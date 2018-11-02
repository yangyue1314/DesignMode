using System;


/// <summary>
/// 实现了子系统（systemone）和客户（main）之间的松耦合，有助于建立层次系统
/// </summary>
namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.MethodOne();
            facade.MethodTwo();
        }
    }
}
