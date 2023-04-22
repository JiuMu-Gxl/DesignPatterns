using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Model
{
    /// <summary>
    /// 创建对应产品创建者
    /// </summary>
    public class Iphone14Builder : Builder
    {
        protected override string SetName()
        {
            return "iphone14";
        }

        protected override string BuildCpu()
        {
            return "A15";
        }

        protected override string BuildMemory()
        {
            return "6 + 128GB";
        }

        protected override string BuildScreen()
        {
            return "2532x1170px 1080P";
        }

        /// <summary>
        /// 构建产品 
        /// 如不创建此函数 则默认使用默认流程
        /// 如本创建者个人习惯，喜好其他流程可再次重写流程
        /// </summary>
        /// <returns></returns>
        public override Phone Build()
        {
            return base.Build();
        }
    }
}
