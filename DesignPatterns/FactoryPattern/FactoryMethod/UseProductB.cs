using FactoryPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod
{
    public class UseProductB : IFactoryMethod
    {
        public AbstractProduct GetInstance()
        {
            var productB = new ProductB();
            Console.WriteLine("创建产品B");
            return productB;
        }
    }
}
