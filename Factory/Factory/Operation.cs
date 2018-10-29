using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class Operation
    {
        private float numberA = 0;
        private float numberB = 0;

        public float NumberA
        {
            get
            {
                return numberA;
            }
            set
            {
                numberA = value;
            }
        }

        public float NumberB
        {
            get
            {
                return numberB;
            }
            set
            {
                numberB = value;
            }
        }

        protected float result = 0;

        public virtual float GetResult()
        {
            return result;
        }
    }
}
