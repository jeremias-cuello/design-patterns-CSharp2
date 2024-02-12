using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    abstract class Singleton<T>
    {
        private static T instance;

        protected Singleton() { }

        public static T GetInstance(params object[] args)
        {
            if (instance == null)
            {
                instance = (T) Activator.CreateInstance(typeof(T), args);
            }
            return instance;
        }
    }
}
