// See https://aka.ms/new-console-template for more information
using SingletonPattern;
using SingletonPattern.HungryManMode;
using SingletonPattern.LazyManMode;
using SingletonPattern.Lock;
using SingletonPattern.SingleGeneric;

Console.WriteLine("------------------------- 单例模式 -------------------------");

#region 饿汉模式
Console.WriteLine("--------------- 饿汉模式 ---------------");
var hungryManMode1 = HungryManMode.GetInstence();
Console.WriteLine($"单例-饿汉模式：{hungryManMode1.InstenceCount()}");
var hungryManMode2 = HungryManMode.GetInstence();
Console.WriteLine($"单例-饿汉模式：{hungryManMode2.InstenceCount()}");

var model1 = new Model1();
Console.WriteLine($"非单例模式：{model1.GetCount()}");
var model2 = new Model1();
Console.WriteLine($"非单例模式：{model2.GetCount()}");
#endregion

#region 懒汉模式
Console.WriteLine("\n--------------- 懒汉模式 ---------------");
var lazyManMode1 = LazyManMode.GetInstance();
Console.WriteLine($"单例-懒汉模式：{lazyManMode1.InstenceCount()}");
var lazyManMode2 = LazyManMode.GetInstance();
Console.WriteLine($"单例-懒汉模式：{lazyManMode2.InstenceCount()}");
lazyManMode1.Reset();
var lazyManMode3 = LazyManMode.GetInstance();
Console.WriteLine($"单例-懒汉模式：{lazyManMode3.InstenceCount()}");

var model3 = new Model1();
Console.WriteLine($"非单例模式：{model3.GetCount()}");
var model4 = new Model1();
Console.WriteLine($"非单例模式：{model4.GetCount()}");
#endregion

#region 锁机制
Console.WriteLine("\n--------------- 锁机制 ---------------");
for (int i = 0; i < 10; i++)
{
    Thread thread = new Thread(ExecuteInForeground);
    thread.Start();
}
static void ExecuteInForeground()
{
    var lockMode = LockMode.GetInstance();
    Console.WriteLine($"单例-锁机制：{lockMode.InstenceCount()}");
}

Console.WriteLine();
for (int i = 0; i < 10; i++)
{
    Thread thread = new Thread(ExecuteInForegroundNoLocked);
    thread.Start();
}

lazyManMode1.Reset();
static void ExecuteInForegroundNoLocked()
{
    var lazyManMode3 = LazyManMode.GetInstance();
    Console.WriteLine($"单例-无锁：{lazyManMode3.InstenceCount()}");
}
#endregion

#region 泛型单例
Console.WriteLine("\n--------------- 泛型单例 ---------------");
var singleClass1_1 = SingleClass1.GetInstance();
Console.WriteLine($"单例-泛型单例-SingleClass1：{singleClass1_1.InstenceCount()}");
var singleClass1_2 = SingleClass1.GetInstance();
Console.WriteLine($"单例-泛型单例-SingleClass1：{singleClass1_2.InstenceCount()}");
Console.WriteLine();
var singleClass2_1 = SingleClass2.GetInstance();
Console.WriteLine($"单例-泛型单例-SingleClass2：{singleClass2_1.InstenceCount()}");
var singleClass2_2 = SingleClass2.GetInstance();
Console.WriteLine($"单例-泛型单例-SingleClass2：{singleClass2_2.InstenceCount()}");

Console.WriteLine();
var singleClass3_1 = SingleClass3.GetInstance();
Console.WriteLine($"单例-泛型单例-SingleClass3：{singleClass3_1.InstenceCount()}");
var singleClass3_2 = SingleClass3.GetInstance();
Console.WriteLine($"单例-泛型单例-SingleClass3：{singleClass3_1.InstenceCount()}");
#endregion



