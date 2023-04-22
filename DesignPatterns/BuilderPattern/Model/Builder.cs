using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Model
{
    /// <summary>
    /// 抽象创建者步骤
    /// </summary>
    public abstract class Builder
    {
        protected abstract string SetName();
        /// <summary>
        /// Cpu
        /// </summary>
        protected abstract string BuildCpu();
        /// <summary>
        /// 屏幕
        /// </summary>
        protected abstract string BuildScreen();
        /// <summary>
        /// 内存
        /// </summary>
        protected abstract string BuildMemory();

        /// <summary>
        /// 构建过程为固定的
        /// 也可由子类（对应创建者）override重写
        /// </summary>
        /// <returns></returns>
        public virtual Phone Build() {
            return new Phone
            {
                PhoneName = SetName(),
                Cpu = BuildCpu(),
                Screen = BuildScreen(),
                Memory = BuildMemory()
            };
        }
    }
}
