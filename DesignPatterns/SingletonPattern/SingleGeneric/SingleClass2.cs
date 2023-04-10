using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.SingleGeneric
{
    public class SingleClass2 : SingleBase<SingleClass2>
    {
        private int _count = 0;
        private SingleClass2() { }

        public int InstenceCount()
        {
            return ++_count;
        }
    }
}
