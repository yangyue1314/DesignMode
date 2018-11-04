using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public enum Size
    {
        Larger,
        Middle,
        Small
    }


    abstract class Beverage
    {
        public Size size;
        public float price;
        public string description = "unknow beverage";

        public abstract string GetDescription();


        public abstract float Cost();


        public virtual float UpdatePriceBySize(Size size)
        {
            this.size = size;
            float tmp = price;
            switch (size)
            {
                case Size.Larger:
                    tmp *= 1f;
                    break;
                case Size.Middle:
                    tmp *= 0.8f;
                    break;
                case Size.Small:
                    tmp *= 0.6f;
                    break;
            }
            return tmp;
        }

    }
}
