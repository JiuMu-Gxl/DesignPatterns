using FactoryPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AbstractFactory
{
    public class CompanyA : IAbstractFactory
    {
        public CompanyA() {
            Console.WriteLine($"声明公司{this.GetType().Name}");
        }
        public AbstractProduct GetProductA()
        {
            var productA = new ProductA();
            Console.WriteLine($"声明公司{this.GetType().Name},产品{productA.GetType().Name}");
            return productA;
        }

        public AbstractProduct GetProductB()
        {
            var productB = new ProductB();
            Console.WriteLine($"声明公司{this.GetType().Name},产品{productB.GetType().Name}");
            return productB;
        }
    }
}
