using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Library
{
    /// <summary>
    /// 混音器
    /// </summary>
    public class AudioMixer
    {
        public FileStream Fix(VideoFile result)
        {
            Console.WriteLine("混音器开始修复音频");
            using var fileStream = new FileStream("123.txt", FileMode.Open, FileAccess.Read);
            return fileStream;
        }
    }
}
