using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FacadePattern.Library
{
    public class VideoFile
    {
        private readonly string _filename;
        private readonly string _codecType;

        public VideoFile(string filename)
        {
            _filename = filename;
            _codecType = filename.Substring(filename.IndexOf(".") + 1);
        }

        public String getCodecType()
        {
            return _codecType;
        }

        public String getName()
        {
            return _filename;
        }
    }
}
