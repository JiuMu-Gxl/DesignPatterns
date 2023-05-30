using BridgePatern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatern.Device
{
    /// <summary>
    /// 电视
    /// </summary>
    public class Tv : IDevice
    {
        private const string Name = "电视";
        // 电源
        private bool Power = false;
        // 音量
        private int Volume = 30;
        // 频道
        private int Channel = 1;

        public void Disable()
        {
            Power = false;
        }

        public void Enable()
        {
            Power = true;
        }

        public int GetChannel()
        {
            return Channel;
        }

        public int GetVolume()
        {
            return Volume;
        }

        public bool IsEnabled()
        {
            return Power;
        }

        public void SetChannel(int channel)
        {
            this.Channel = channel;
        }

        public void SetVolume(int volume)
        {
            if (volume > 100)
            {
                this.Volume = 100;
            }
            else if (volume < 0)
            {
                this.Volume = 0;
            }
            else
            {
                this.Volume = volume;
            }
        }

        public void PrintStatus()
        {
            Console.WriteLine($"--------------- {Name}当前设置 ---------------");
            Console.WriteLine($"电源：{(this.Power ? "开" : "关")}");
            Console.WriteLine($"音量：{this.Volume}%");
            Console.WriteLine($"频道：{this.Channel}");
            Console.WriteLine("------------------------------\n");
        }
    }
}
