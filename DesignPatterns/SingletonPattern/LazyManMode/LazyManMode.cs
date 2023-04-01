using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.LazyManMode
{
    /// <summary>
    /// 单例模式（懒汉模式）
    /// 延迟初始化
    /// </summary>
    public class LazyManMode
    {
        // 定义为static，保证变量为线程安全的，即每个线程一个实例
        private static LazyManMode instance;
        private int _count = 0;

        // 让构造函数为 private，这样该类就不会被实例化
        private LazyManMode() { }

        public static LazyManMode GetInstance()
        {
            return instance ?? (instance = new LazyManMode());
        }

        /// <summary>
        /// 使用此方法销毁已创建的实例
        /// </summary>
        public void Reset()
        {
            instance = null;
        }

        /// <summary>
        /// 累加数据
        /// 如果是单例则数值会累加，若不为单例则会每次都会展示 1
        /// </summary>
        /// <returns></returns>
        public int InstenceCount()
        {
            return ++_count;
        }

    }
}
