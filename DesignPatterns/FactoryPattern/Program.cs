// See https://aka.ms/new-console-template for more information

using FactoryPattern.AbstractFactory;
using FactoryPattern.FactoryMethod;
using FactoryPattern.Model;
using FactoryPattern.ReflectFactory;
using FactoryPattern.SimpleFactory;

Console.WriteLine("------------------------- 工厂模式 -------------------------");

#region 简单工厂
Console.WriteLine("--------------- 简单工厂 ---------------");
var simpleFactoryA = SimpleFactory.GetInstance(ProductEnum.ProductA);
simpleFactoryA.GetInfo();
simpleFactoryA.GetSelfName();
var simpleFactoryB = SimpleFactory.GetInstance(ProductEnum.ProductB);
simpleFactoryB.GetInfo();
simpleFactoryB.GetSelfName();
#endregion

#region 反射工厂
Console.WriteLine("--------------- 反射工厂 ---------------");
var reflectFactoryA = ReflectFactory.GetInstance<ProductA>();
reflectFactoryA.GetInfo();
reflectFactoryA.GetSelfName();
var reflectFactoryB = ReflectFactory.GetInstance<ProductB>();
reflectFactoryB.GetInfo();
reflectFactoryB.GetSelfName();
#endregion

#region 工厂方法
Console.WriteLine("--------------- 工厂方法 ---------------");
var factoryMethodA = new UseProductA();
var factoryMethodProductA = factoryMethodA.GetInstance();
factoryMethodProductA.GetInfo();
factoryMethodProductA.GetSelfName();

var factoryMethodB = new UseProductB();
var factoryMethodProductB = factoryMethodB.GetInstance();
factoryMethodProductB.GetInfo();
factoryMethodProductB.GetSelfName();
#endregion

#region 抽象工厂
Console.WriteLine("--------------- 抽象工厂 ---------------");
var companyA = new CompanyA();
var companyAProductA = companyA.GetProductA();
companyAProductA.GetInfo();
companyAProductA.GetSelfName();
Console.WriteLine();

var companyAProductB = companyA.GetProductB();
companyAProductB.GetInfo();
companyAProductB.GetSelfName();
Console.WriteLine();

var companyB = new CompanyB();
var companyBProductA = companyB.GetProductA();
companyBProductA.GetInfo();
companyBProductA.GetSelfName();
Console.WriteLine();

var companyBProductB = companyB.GetProductB();
companyBProductB.GetInfo();
companyBProductB.GetSelfName();
Console.WriteLine();
#endregion

