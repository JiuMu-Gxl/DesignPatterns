using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Model.Peg
{
    /// <summary>
    /// 圆头钉
    /// </summary>
    public class RoundPeg
    {
        /// <summary>
        /// 半径
        /// </summary>
        private double radius;

        public RoundPeg(double radius)
        {
            this.radius = radius;
        }

        public double GetRadius() {
            return radius;
        }
    }
}
