using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationPattern.Model
{
    /// <summary>
    /// 服务员
    /// </summary>
    public class Waitress
    {
        private readonly MenuComponent _allMenus;

        public Waitress(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        /// <summary>
        /// 展示菜单
        /// </summary>
        public void Print() { 
            _allMenus.Print();
        }
    }
}
