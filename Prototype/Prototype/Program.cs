using System;


/// <summary>
/// 原型模式(当创建新对象成本比较大时可以使用)
/// 此案例是深拷贝
/// 浅拷贝：被复制对象所有的变量都含有与原来对象相同的值
///         但所有的对其它对象（WorkExperience）的引用都还是指向原来的对象
/// 深拷贝：在浅拷贝的基础上，把引用对象的变量指向复制过得新对象
/// </summary>
namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume a = new Resume("yangyue");
            a.SetPersonalInfo("男", "22");
            a.SetWorkExperience("1996", "A公司");

            Resume b = (Resume)a.Clone();
            b.SetWorkExperience("1997", "B公司");

            Resume c = (Resume)a.Clone();
            c.SetWorkExperience("1998", "C公司");

            a.Display();
            b.Display();
            c.Display();
        }
    }
}
