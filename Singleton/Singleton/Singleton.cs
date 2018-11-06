using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Singleton
    {
        private Singleton() { }
        private static readonly object locker = new object();
        private static Singleton instance;
        public static Singleton GetInstance()
        {
            if(instance==null)
            {
                lock(locker)
                {
                    if(instance==null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }
    }
}
