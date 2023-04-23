// See https://aka.ms/new-console-template for more information

using PrototypePattern;

Console.WriteLine("------------------------- 原型模式 -------------------------");

var zhangsan = new User { Name = "张三", Email = "zhangsan@123.com" };
var lisi = new User { Name = "李四", Email = "lisi@123.com" };
var wangwu = new User { Name = "王五", Email = "wangwu@123.com" };

Email email = new Email { Sender = zhangsan, Addressee = lisi, Title = "张三至李四邮件", Content = "这是通过原型模式至李四的邮件" };
email.ToString();
Console.WriteLine();
// 浅拷贝
Email email1 = email.Clone() as Email;
// 浅拷贝
Email email2 = email.ShallowCopy();
// 深拷贝
Email email3 = email.DeepCopy();
email.Sender.Name = "麻子";
email.Sender.Email = "mazi@999.com";
email.Addressee = wangwu;
email.Title = "李四至王五邮件";
email.Addressee.Email = "zhangsan@123.com";
email.ToString();
Console.WriteLine();

email1.ToString();
Console.WriteLine();

email2.ToString();
Console.WriteLine();

email3.ToString();


