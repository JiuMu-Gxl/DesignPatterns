using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// 通用数据操作接口
    /// </summary>
    public interface IDataSource
    {
        /// <summary>
        /// 写入数据
        /// </summary>
        void WriteData(string data);

        /// <summary>
        /// 读取数据
        /// </summary>
        /// <returns></returns>
        string ReadData();
    }
}
