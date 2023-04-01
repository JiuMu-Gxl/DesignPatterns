using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Lock
{
    /// <summary>
    /// 单例模式（）
    /// </summary>
    public class LockMode
    {
        // 定义为static，保证变量为线程安全的，即每个线程一个实例
        // volatile 关键字指示一个字段可以由多个同时执行的线程修改
        private static volatile LockMode instance;
        private static readonly object Locker = new object();
        private int _count = 0;

        // 让构造函数为 private，这样该类就不会被实例化
        private LockMode() { }

        public static LockMode GetInstance() {
            //return instance ?? (instance = new LockMode());

            #region 双检锁
            // 没有第一重instence == null，每次线程进入GetInstance()时，均会执行锁定操作实现线程同步，非常消耗性能
            // 增加第一重instence == null 判断避免其他无用线程竞争锁造成线程浪费 成立的情况下执行一次锁定以实现线程同步
            if (instance == null)
            {
                lock (Locker)
                {
                    // 第二重检测锁定 可以拦截除第一个获得对象锁线程外的线程
                    return instance ?? (instance = new LockMode());
                }
            } 
            #endregion
            return instance;
        }

        public int InstenceCount() {
            return ++_count;
        }

    }
}
