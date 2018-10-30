using System;


/// <summary>
/// 策略模式根据传入不同的参数调用相同的接口执行对应的算法
/// </summary>
namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context("正常收费");
            context.ContextInterface();
        }
    }
}
