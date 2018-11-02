using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Facade
    {
        SystemOne systemOne;
        SystemTwo systemTwo;
        SystemThree systemThree;

        public Facade()
        {
            systemOne = new SystemOne();
            systemTwo = new SystemTwo();
            systemThree = new SystemThree();
        }

        public void MethodOne()
        {
            systemOne.MethodOne();
            systemThree.MethodThree();
        }

        public void MethodTwo()
        {
            systemTwo.MethodTwo();
            systemOne.MethodOne();
            systemThree.MethodThree();
        }
    }
}
