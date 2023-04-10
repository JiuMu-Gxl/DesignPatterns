using FactoryPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod
{
    public interface IFactoryMethod
    {
        AbstractProduct GetInstance();
    }
}
