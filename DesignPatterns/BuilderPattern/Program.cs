// See https://aka.ms/new-console-template for more information


using BuilderPattern.Model;

Console.WriteLine("------------------------- 建造者模式 -------------------------");


// 声明一个销售领导者
Director director = new Director();
// 声明每个手机型号的创建人
Iphone14Builder iphone14 = new Iphone14Builder();
Iphone14PlusBuilder iphone14Plus = new Iphone14PlusBuilder();

// 进入先找销售进行订货，告知销售需要iphone14手机
// 销售将订单给到对应手机型号创建人
director.SetBuilder(iphone14);
// 手机创建人后台自动生成手机，无需让用户知道流程
// 过几天，找到销售进行提货，给到你想要的Iphone14
Phone phone = director.Delivery();

Console.WriteLine();
// 另一个用户需要另一个手机，只需同样流程找销售者即可
// 购买Iphone14Plus
director.SetBuilder(iphone14Plus);
Phone phone1 = director.Delivery();
