using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Model
{
    public class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "适配器功能";
        }
    }
}
