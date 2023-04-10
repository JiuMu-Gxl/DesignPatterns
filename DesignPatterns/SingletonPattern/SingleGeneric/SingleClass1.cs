using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.SingleGeneric
{
    public class SingleClass1 : SingleBase<SingleClass1>
    {
        private int _count = 0;

        private SingleClass1() { }

        public int InstenceCount()
        {
            return ++_count;
        }
    }
}
