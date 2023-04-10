using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.SingleGeneric
{
    /// <summary>
    /// 泛型单例
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SingleBase<T> where T : class
    {
        private static volatile T instance;
        private static readonly object Locker = new object();

        protected SingleBase() { }

        public static T GetInstance() {
            //return instance ?? (instance = Activator.CreateInstance(typeof(T), true) as T);
            if (instance == null)
            {
                lock (Locker)
                {
                    return instance ?? (instance = Activator.CreateInstance(typeof(T), true) as T);
                }
            }
            return instance;
        }
    }
}
