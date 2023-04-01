// See https://aka.ms/new-console-template for more information
using SingletonPattern;
using SingletonPattern.HungryManMode;
using SingletonPattern.LazyManMode;
using SingletonPattern.Lock;

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
Console.WriteLine("--------------- 懒汉模式 ---------------");
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
Console.WriteLine("--------------- 锁机制 ---------------");
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
#endregion

