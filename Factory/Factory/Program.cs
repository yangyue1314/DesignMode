using System;


/// <summary>
/// 工厂模式通过不同的条件生产不同的class
/// </summary>
namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation;
            operation = OperationFactory.CreatOperate("-");
            operation.NumberA = 1;
            operation.NumberB = 2;
            Console.WriteLine(operation.GetResult());
        }
    }
}
