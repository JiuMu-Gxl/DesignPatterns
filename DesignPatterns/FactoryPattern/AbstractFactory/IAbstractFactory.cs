using FactoryPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AbstractFactory
{
    public interface IAbstractFactory
    {
        AbstractProduct GetProductA();
        AbstractProduct GetProductB();
    }
}
