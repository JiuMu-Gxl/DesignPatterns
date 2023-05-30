using AdapterPattern.Model.Peg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Model.Hole
{
    /// <summary>
    /// 圆孔
    /// </summary>
    public class RoundHole
    {
        /// <summary>
        /// 半径
        /// </summary>
        private double radius;

        public RoundHole(double radius)
        {
            this.radius = radius;
        }

        public double GetRadius() {
            return radius;
        }

        /// <summary>
        /// 是否合身
        /// </summary>
        /// <param name="peg"></param>
        /// <returns></returns>
        public bool Fits(RoundPeg peg) {
            return this.GetRadius() >= peg.GetRadius();
        }
    }
}
