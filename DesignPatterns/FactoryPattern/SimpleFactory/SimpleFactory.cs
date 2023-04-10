using FactoryPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.SimpleFactory
{
    /// <summary>
    /// 简单工厂（静态工厂方法）
    /// 由一个工厂对象决定创建哪一个产品类
    /// </summary>
    public static class SimpleFactory
    {
        public static AbstractProduct GetInstance(ProductEnum productType) {
            switch (productType)
            {
                case ProductEnum.ProductA:
                    return new ProductA();
                case ProductEnum.ProductB:
                    return new ProductB();
                default:
                    return null;
            }
        }
    }

    /// <summary>
    /// 产品枚举
    /// </summary>
    public enum ProductEnum
    {
        ProductA,
        ProductB
    }
}
