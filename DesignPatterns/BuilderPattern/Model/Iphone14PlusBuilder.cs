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
    public class Iphone14PlusBuilder : Builder
    {
        protected override string SetName()
        {
            return "iphone14 Plus";
        }
        protected override string BuildCpu()
        {
            return "A15";
        }

        protected override string BuildMemory()
        {
            return "6 + 256GB";
        }

        protected override string BuildScreen()
        {
            return "2778x1284px 1080P";
        }


        /// <summary>
        /// 构建产品 
        /// 如不创建此函数 则默认使用默认流程
        /// 如本创建者个人习惯，喜好在某些流程特殊操作，可override重写进行操作
        /// 例：Iphone14Plus的创建者有个恶趣习惯喜欢在CPU上刻上自己的名字
        /// </summary>
        /// <returns></returns>
        public override Phone Build()
        {
            return new Phone
            {
                PhoneName = SetName(),
                Cpu = "小高组装的" + BuildCpu(),
                Memory = BuildMemory(),
                Screen = BuildScreen()
            };
        }
    }
}
