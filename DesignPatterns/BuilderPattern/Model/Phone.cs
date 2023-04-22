using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Model
{
    public class Phone
    {
        public string PhoneName { get; set; }
        public string Cpu { get; set; }
        public string Screen { get; set; }
        public string Memory { get; set; }

        public void BuildPhone() {
            Console.WriteLine($"---------- {PhoneName} ----------");
            Console.WriteLine($"开始组装 {PhoneName}");
            Console.WriteLine($"组装CPU: {Cpu}");
            Console.WriteLine($"组装屏幕: {Screen}");
            Console.WriteLine($"设定手机内存: {Memory}");
            Console.WriteLine($"{PhoneName} 组装完成");
        }
    }
}
