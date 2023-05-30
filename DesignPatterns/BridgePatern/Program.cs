// See https://aka.ms/new-console-template for more information

using BridgePatern.Device;
using BridgePatern.Remote;

// 桥接可以通过一些控制实体及其所依赖的多个不同平台之间的明确区别来进行识别。
Console.WriteLine("------------------------- 桥接模式 -------------------------");

// 声明电视和收音机
var radio = new Radio();
var tv = new Tv();

Console.WriteLine("--------------- 测试基础遥控 ---------------");
BasicRemote basicRemote = new BasicRemote(radio);
basicRemote.Power();
basicRemote.ChannelUp();
basicRemote.ChannelUp();
basicRemote.VolumeUp();
basicRemote.VolumeUp();
basicRemote.VolumeUp();
basicRemote.Power();
Console.WriteLine("--------------- 测试结束 ---------------");
radio.PrintStatus();

Console.WriteLine("--------------- 测试高级遥控 ---------------");
AdvancedRemote advancedRemote = new AdvancedRemote(tv);
advancedRemote.Power();
advancedRemote.ChannelUp();
advancedRemote.ChannelUp();
advancedRemote.ChoiceChannels();
advancedRemote.VolumeUp();
advancedRemote.VolumeUp();
advancedRemote.VolumeUp();
advancedRemote.Mute();
advancedRemote.Power();
Console.WriteLine("--------------- 测试结束 ---------------");
tv.PrintStatus();




