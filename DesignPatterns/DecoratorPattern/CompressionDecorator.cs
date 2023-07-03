using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// 压缩装饰
    /// </summary>
    public class CompressionDecorator : DataSourceDecorator
    {

        public CompressionDecorator(IDataSource dataSource) : base(dataSource)
        {
        }

        public override void WriteData(string data)
        {
            base.WriteData(Compress(data));
        }

        public override string ReadData()
        {
            return Decompress(base.ReadData());
        }

        /// <summary>
        /// 压缩
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private string Compress(string data)
        {
            byte[] result = Encoding.UTF8.GetBytes(data);
            using MemoryStream compressStream = new MemoryStream();
            using (var zipStream = new GZipStream(compressStream, CompressionMode.Compress))
            {
                zipStream.Write(result, 0, result.Length);
            }
            byte[] compressBytes = compressStream.ToArray();
            string resultStr = Convert.ToBase64String(compressBytes);

            Console.WriteLine($"压缩后字节长度：{compressBytes.Length}\t压缩后结果：" + resultStr);
            return resultStr;
        }

        /// <summary>
        /// 解压
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private string Decompress(string data)
        {
            byte[] result = Convert.FromBase64String(data);
            using var compressStream = new MemoryStream(result);
            using var zipStream = new GZipStream(compressStream, CompressionMode.Decompress);
            using var resultStream = new MemoryStream();
            zipStream.CopyTo(resultStream);
            var compressBytes = resultStream.ToArray();
            string resultStr = Encoding.Default.GetString(compressBytes);

            Console.WriteLine($"解压后字节长度：{compressBytes.Length}\t解压后结果：" + resultStr);
            return resultStr;
        }
    }
}
