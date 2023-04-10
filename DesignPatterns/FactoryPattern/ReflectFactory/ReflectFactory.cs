using FactoryPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.ReflectFactory
{
    /// <summary>
    /// 反射工厂（基于简单工厂的扩展）
    /// </summary>
    public static class ReflectFactory
    {
        public static AbstractProduct GetInstance<T>() where T : AbstractProduct
        {
            return Activator.CreateInstance(typeof(T), true) as AbstractProduct;
        }
    }
}
