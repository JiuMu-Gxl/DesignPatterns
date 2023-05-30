// See https://aka.ms/new-console-template for more information

using CombinationPattern.Model;

Console.WriteLine("------------------------- 组合模式 -------------------------");

var MilkTeaMenu = new Menu("奶茶菜单", "你爱我，我爱你\n蜜雪冰城甜蜜蜜");
MilkTeaMenu.Add(new Dishes("菠萝爱情海", "菠萝菠萝粒，阳光夏威夷", 7, true));
MilkTeaMenu.Add(new Dishes("百香芒芒", "雪王好芒，芒果好香！", 7, false));
MilkTeaMenu.Add(new Dishes("桃喜芒芒", "雪王好芒，芒果好香！", 7, false));
MilkTeaMenu.Add(new Dishes("鲜橙大王桶", "鲜橙大王桶，出道即爆红", 10, true));
MilkTeaMenu.Add(new Dishes("三拼霸霸奶茶", "三拼霸霸嚼嚼嚼，珍珠椰果鸡蛋布丁", 8, false));
MilkTeaMenu.Add(new Dishes("蜜桃四季春", "蜜桃四季春，四季桃花运", 6, false));
MilkTeaMenu.Add(new Dishes("芋圆奶茶", "奶茶小团圆，软糯小芋圆", 8, false));
MilkTeaMenu.Add(new Dishes("美式咖啡", "鲜萃云南豆，国货好咖啡", 4, false));
MilkTeaMenu.Add(new Dishes("菠萝甜心橙", "菠萝菠萝粒，阳光夏威夷", 8, true));

var FoodMenu = new Menu("徽菜菜单", "小菜园，母亲的味道！");
FoodMenu.Add(new Dishes("徽州臭鳜鱼", "徽州臭鳜鱼", 68, false));
FoodMenu.Add(new Dishes("农家红烧肉", "农家红烧肉", 48, true));
FoodMenu.Add(new Dishes("老坛酸菜牛肉", "老坛酸菜牛肉", 58, false));
FoodMenu.Add(new Dishes("地锅本仔鸡", "地锅本仔鸡！", 65, false));
FoodMenu.Add(new Dishes("石板牛仔骨", "石板牛仔骨！", 55, false));
FoodMenu.Add(new Dishes("石板蒜蓉虾", "石板蒜蓉虾", 48, false));
FoodMenu.Add(new Dishes("情咖鸡翅", "情咖鸡翅", 38, false));

var allMenus = new Menu("总菜单", "所有菜品");
allMenus.Add(MilkTeaMenu);
allMenus.Add(FoodMenu);


var waitress = new Waitress(allMenus);
waitress.Print();
