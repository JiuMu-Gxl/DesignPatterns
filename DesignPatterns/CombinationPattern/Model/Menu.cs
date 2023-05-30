using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationPattern.Model
{
    public class Menu : MenuComponent
    {
        private List<MenuComponent> _menuComponents;

        public override string Name { get; }
        public override string Description { get; }

        public Menu(string name, string description)
        {
            Name = name;
            Description = description;
            _menuComponents = new List<MenuComponent>();
        }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int id)
        {
            return _menuComponents[id];
        }

        /// <summary>
        /// 展示菜单信息和菜单内所有菜品信息
        /// </summary>
        public override void Print()
        {
            Console.WriteLine("--------------- 菜单 ---------------");
            Console.WriteLine($"菜单名称：{this.Name}");
            Console.WriteLine($"菜单介绍：{this.Description}");

            // 根据最热菜系排序
            _menuComponents = _menuComponents.OrderBy(x => !x.IsHot).ToList();

            Console.WriteLine("---------- 菜品 ----------");
            var index = 1;
            foreach (var item in _menuComponents)
            {
                item.Print();
                if (index % 5 == 0 || index == _menuComponents.Count)
                {
                    Console.WriteLine($"----- 第{(index / 6 + 1)}页 -----");
                }
                index++;
            }
        }

    }
}
