using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Library
{
    /// <summary>
    /// 格式工厂
    /// </summary>
    public class CodecFactory
    {
        public static ICodec Extract(VideoFile video) { 
            string file = video.getCodecType();
            if (file.Equals("mp4"))
            {
                Console.WriteLine("格式工厂：提取mp4音频");
                return new MPEG4CompressionCodec();
            }
            else
            {
                Console.WriteLine("格式工厂：提取ogg音频");
                return new OggCompressionCodec();
            }
        }
    }
}
