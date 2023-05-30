using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatern.Interface
{
    /// <summary>
    /// 所有设备的通用接口（设备接收器）
    /// </summary>
    public interface IDevice
    {
        /// <summary>
        /// 电源是否打开
        /// </summary>
        /// <returns></returns>
        bool IsEnabled();

        /// <summary>
        /// 启用
        /// </summary>
        void Enable();

        /// <summary>
        /// 禁用
        /// </summary>
        void Disable();

        /// <summary>
        /// 获取声音
        /// </summary>
        /// <returns></returns>
        int GetVolume();

        /// <summary>
        /// 设置音量
        /// </summary>
        /// <param name="volume"></param>
        void SetVolume(int volume);

        /// <summary>
        /// 获取频道
        /// </summary>
        /// <returns></returns>
        int GetChannel();

        /// <summary>
        /// 设置频道
        /// </summary>
        /// <param name="channel"></param>
        void SetChannel(int channel);

        /// <summary>
        /// 打印状态
        /// </summary>
        void PrintStatus();
    }
}
