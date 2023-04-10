using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Model
{
    public abstract class AbstractProduct
    {
        public abstract string Name { get; }
        public abstract void GetSelfName();

        public void GetInfo() {
            Console.WriteLine($"{this.GetType().Name}");
        }
    }
}
