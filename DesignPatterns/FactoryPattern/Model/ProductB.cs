using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Model
{
    public class ProductB : AbstractProduct
    {
        public override string Name => "产品B";

        public override void GetSelfName()
        {
            Console.WriteLine($"{this.Name}，已创建");
        }
    }
}
