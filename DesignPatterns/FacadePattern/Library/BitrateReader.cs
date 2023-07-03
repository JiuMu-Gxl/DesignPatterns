using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Library
{
    /// <summary>
    /// 读取器
    /// </summary>
    public class BitrateReader
    {
        public static VideoFile Read(VideoFile video, ICodec codec) {
            Console.WriteLine("读取器开始读取。。。");
            return video;
        }

        public static VideoFile Convert(VideoFile video, ICodec codec)
        {
            Console.WriteLine($"读取器开始转换视频格式。。。");
            return video;
        }
    }
}
