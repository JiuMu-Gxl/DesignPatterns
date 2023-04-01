using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.HungryManMode
{
    public class Model1
    {
        private int count = 0;

        public int GetCount()
        {
            return ++count;
        }
    }
}
