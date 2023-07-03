// See https://aka.ms/new-console-template for more information


using DecoratorPattern;

Console.WriteLine("------------------------- 装饰模式 -------------------------");

String str = "姓名\t年龄\n张三\t22\n李四\t26\n王五\t18";


#region 加密装饰
var encryption = new EncryptionDecorator(new FileDataSource("encryption.txt"));
encryption.WriteData(str);
IDataSource encryptionEataSource = new FileDataSource("encryption.txt");

Console.WriteLine("--------------- 输入 ---------------");
Console.WriteLine(str);
Console.WriteLine("--------------- 加密 ---------------");
Console.WriteLine(encryptionEataSource.ReadData());
Console.WriteLine("--------------- 解密 ---------------");
Console.WriteLine(encryption.ReadData());
Console.WriteLine("\n");
#endregion

#region 压缩装饰
var compression = new CompressionDecorator(new FileDataSource("compression.txt"));
compression.WriteData(str);
IDataSource compressionEataSource = new FileDataSource("compression.txt");

Console.WriteLine("--------------- 输入 ---------------");
Console.WriteLine(str);
Console.WriteLine("--------------- 压缩 ---------------");
Console.WriteLine(compressionEataSource.ReadData());
Console.WriteLine("--------------- 解压 ---------------");
Console.WriteLine(compression.ReadData());
Console.WriteLine("\n");
#endregion

#region 加密-压缩 装饰
var decorator = new CompressionDecorator(new EncryptionDecorator(new FileDataSource("output.txt")));
decorator.WriteData(str);
IDataSource dataSource = new FileDataSource("output.txt");

Console.WriteLine("--------------- 输入 ---------------");
Console.WriteLine(str);
Console.WriteLine("--------------- 加密-压缩 ---------------");
Console.WriteLine(dataSource.ReadData());
Console.WriteLine("--------------- 解密-解压 ---------------");
Console.WriteLine(decorator.ReadData()); 
#endregion

