using FactoryPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod
{
    public class UseProductA : IFactoryMethod
    {
        public AbstractProduct GetInstance()
        {
            var productA = new ProductA();
            Console.WriteLine("创建产品A");
            return productA;
        }
    }
}
