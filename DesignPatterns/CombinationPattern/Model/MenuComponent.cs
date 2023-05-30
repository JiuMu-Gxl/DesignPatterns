using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationPattern.Model
{
    /// <summary>
    /// 组合菜单容器
    /// </summary>
    public abstract class MenuComponent
    {
        public virtual string Name => throw new NotSupportedException();
        public virtual string Description => throw new NotSupportedException();
        public virtual double Price => 0;
        public virtual bool IsHot => false;

        public virtual void Add(MenuComponent menuComponent) 
        {
            throw new NotSupportedException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual MenuComponent GetChild(int id)
        {
            throw new NotSupportedException();
        }

        public virtual void Print()
        {
            throw new NotSupportedException();
        }
    }
}
