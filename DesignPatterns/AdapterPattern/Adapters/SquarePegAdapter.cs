using AdapterPattern.Model.Peg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adapters
{
    /// <summary>
    /// 方头钉到圆孔适配器
    /// </summary>
    public class SquarePegAdapter : RoundPeg
    {
        private SquarePeg peg;

        public SquarePegAdapter(double radius) : base(radius)
        {
            this.peg = new SquarePeg(radius);
        }

        public double GetRadius() {
            return (Math.Sqrt(Math.Pow((peg.GetWidth() / 2), 2) * 2));
        }
    }
}
