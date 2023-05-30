using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatern.Remote
{
    /// <summary>
    /// 所有远程控制器的通用接口（遥控发射器）
    /// </summary>
    public interface IRemote
    {
        /// <summary>
        /// 电源
        /// </summary>
        void Power();

        /// <summary>
        /// 声音-
        /// </summary>
        void VolumeDown();

        /// <summary>
        /// 声音+
        /// </summary>
        void VolumeUp();

        /// <summary>
        /// 频道-
        /// </summary>
        void ChannelDown();

        /// <summary>
        /// 频道+
        /// </summary>
        void ChannelUp();
    }
}
