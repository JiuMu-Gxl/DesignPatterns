using BridgePatern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatern.Remote
{
    /// <summary>
    /// 高级控制器（控制实体）
    /// </summary>
    public class AdvancedRemote : BasicRemote
    {
        public AdvancedRemote(IDevice device) : base(device)
        {
        }

        /// <summary>
        /// 静音
        /// </summary>
        public void Mute() {
            Console.WriteLine("按下静音键");
            _device.SetVolume(0);
        }


        /// <summary>
        /// 手输频道
        /// </summary>
        public void ChoiceChannels()
        {
            Console.WriteLine("手输频道，请输入频道编号");
            var channel = Convert.ToInt32(Console.ReadLine());
            _device.SetChannel(channel);
        }
    }
}
