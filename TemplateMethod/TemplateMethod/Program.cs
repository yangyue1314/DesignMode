using System;

/// <summary>
/// 模板方法是通过把不变的行为（模板方法）放到基类，去除子类重复的代码
/// </summary>
namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass abstractClass;

            abstractClass = new ConcreteClassA();
            abstractClass.TemplateMethod();

            abstractClass = new ConcreteClassB();
            abstractClass.TemplateMethod();
        }
    }
}
