using System;

/// <summary>
/// 为已有功能动态的添加一些功能
/// </summary>
namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new ApplePhone();

            Decorator decorator = new Sticker(phone);

            decorator.Print();

            Console.WriteLine("--------------------\n");

            Sticker sticker = new Sticker(phone);
            Accessories accessories = new Accessories(sticker);
            accessories.Print();
        }
    }
}
