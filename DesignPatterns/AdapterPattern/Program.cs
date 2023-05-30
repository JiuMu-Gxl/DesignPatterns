// See https://aka.ms/new-console-template for more information


using AdapterPattern.Adapters;
using AdapterPattern.Model;
using AdapterPattern.Model.Hole;
using AdapterPattern.Model.Peg;

// 适配器可以通过以不同抽象或接口类型实例为参数的构造函数来识别。
// 当适配器的任何方法被调用时， 它会将参数转换为合适的格式， 然后将调用定向到其封装对象中的一个或多个方法。
Console.WriteLine("------------------------- 适配器模式 -------------------------");

Adaptee adapter = new Adaptee();
ITarget target = new Adapter(adapter);

Console.WriteLine(target.GetRequest());

Console.WriteLine("--------------- 圆头钉是否符合圆孔 ---------------");
RoundHole hole = new RoundHole(5);
RoundPeg reg = new RoundPeg(5);
Console.WriteLine($"是否合身：{(hole.Fits(reg) ? "是" : "否")}");


SquarePegAdapter smallSqPegAdapter = new SquarePegAdapter(2);
SquarePegAdapter largeSqPegAdapter = new SquarePegAdapter(20);
Console.WriteLine($"小方块是否合身：{(hole.Fits(smallSqPegAdapter) ? "是" : "否")}");
Console.WriteLine($"大方块是否合身：{(hole.Fits(largeSqPegAdapter) ? "是" : "否")}");


