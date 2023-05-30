using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationPattern.Model
{
    /// <summary>
    /// 菜品（菜单项）
    /// </summary>
    public class Dishes : MenuComponent
    {
        public override string Name { get; }
        public override string Description { get; }
        public override double Price { get; }
        public override bool IsHot { get; }

        public Dishes(string name, string description, double price, bool isHot)
        {
            Name = name;
            Description = description;
            Price = price;
            IsHot = isHot;
        }

        /// <summary>
        /// 展示菜品信息
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"菜名：{this.Name}{(this.IsHot ? "*" : "")} --- ￥{this.Price}");
            Console.WriteLine($"简介：{this.Description}");
        }
    }
}
