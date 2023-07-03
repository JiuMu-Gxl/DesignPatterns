using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// 简单数据读写器
    /// </summary>
    public class FileDataSource : IDataSource
    {
        private String FileName;

        public FileDataSource(string fileName)
        {
            FileName = fileName;
        }

        public string ReadData()
        {
            using var fileStream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            byte[] bytes = new byte[fileStream.Length];
            fileStream.Read(bytes, 0, bytes.Length);
            // 设置当前流的位置为流的开始
            fileStream.Seek(0, SeekOrigin.Begin);
            //字节转化为string
            return Encoding.UTF8.GetString(bytes);
        }

        public void WriteData(string data)
        {
            using var fileStream = new FileStream(FileName, FileMode.Create, FileAccess.Write);
            fileStream.Write(Encoding.Default.GetBytes(data));
        }
    }
}
