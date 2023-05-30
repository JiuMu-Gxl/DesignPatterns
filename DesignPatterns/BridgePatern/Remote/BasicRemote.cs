using BridgePatern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatern.Remote
{
    /// <summary>
    /// 基础控制器（控制实体）
    /// </summary>
    public class BasicRemote : IRemote
    {
        protected IDevice _device;

        public BasicRemote(IDevice device)
        {
            this._device = device;
        }

        public void ChannelDown()
        {
            Console.WriteLine("按下频道-");
            _device.SetChannel(_device.GetChannel() - 1);
        }

        public void ChannelUp()
        {
            Console.WriteLine("按下频道+");
            _device.SetChannel(_device.GetChannel() + 1);
        }

        public void Power()
        {
            Console.WriteLine("按下电源键");
            if (_device.IsEnabled())
            {
                Console.WriteLine($"关闭");
                _device.Disable();
            }
            else
            {
                Console.WriteLine($"开启");
                _device.Enable();
            }
        }

        public void VolumeDown()
        {
            Console.WriteLine("按下音量-");
            _device.SetVolume(_device.GetVolume() - 10);
        }

        public void VolumeUp()
        {
            Console.WriteLine("按下音量+");
            _device.SetVolume(_device.GetVolume() - 10);
        }
    }
}
