using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// 加密装饰
    /// </summary>
    public class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(IDataSource dataSource) : base(dataSource)
        {
        }

        public override void WriteData(string data)
        {
            base.WriteData(Encode(data));
        }

        public override string ReadData()
        {
            return Decode(base.ReadData());
        }

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private string Encode(string data)
        {
            byte[] result = Encoding.Default.GetBytes(data);
            for (int i = 0; i < result.Length; i++)
            {
                result[i] += 1;
            }
            string resultStr = Convert.ToBase64String(result);

            Console.WriteLine($"加密后字节长度：{result.Length}\t加密后结果：" + resultStr);
            return resultStr;
        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private string Decode(string data)
        {
            byte[] result = Convert.FromBase64String(data);
            for (int i = 0; i < result.Length; i++)
            {
                result[i] -= 1;
            }
            string resultStr = Encoding.UTF8.GetString(result);

            Console.WriteLine($"解密后字节长度：{result.Length}\t解密后结果：" + resultStr);
            return resultStr;
        }
    }
}
