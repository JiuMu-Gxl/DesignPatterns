using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.HungryManMode
{
    /// <summary>
    /// 单例模式（饿汉模式）
    /// 静态变量初始化
    /// 不管有没有需要，类初始化的时候先创建对象
    /// </summary>
    public class HungryManMode
    {
        // 定义为static，保证变量为线程安全的，即每个线程一个实例
        private static readonly HungryManMode instance = new HungryManMode();

        private int _count = 0;

        //让构造函数为 private，这样该类就不会被实例化
        private HungryManMode() { }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <returns></returns>
        public static HungryManMode GetInstence()
        {
            return instance;
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
