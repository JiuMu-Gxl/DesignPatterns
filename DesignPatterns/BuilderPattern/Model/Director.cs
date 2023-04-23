using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Model
{
    /// <summary>
    /// 指挥者（销售）
    /// 由销售接受对应订单并给到用户订单对应产品即可
    /// 产品的构建和功能由创建者实现
    /// 关注产出，不关心细节
    /// </summary>
    public class Director
    {
        public Builder _builder { get; set; }

        public void SetBuilder(Builder builder) {
            _builder = builder;
        }

        /// <summary>
        /// 提货(不需知道制造过程，只需要知道是否完成)
        /// </summary>
        /// <returns></returns>
        public Phone Delivery() {
            var phone = _builder.Build();
            phone.BuildPhone();
            return phone;
        }
    }
}
