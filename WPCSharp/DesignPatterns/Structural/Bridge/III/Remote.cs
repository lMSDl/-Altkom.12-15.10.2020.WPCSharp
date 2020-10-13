using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Bridge.III
{
    public class Remote : IRemote
    {
        public IRemote DeviceAdapter { get; set; }

        public void ChannelDown()
        {
            DeviceAdapter.ChannelDown();
        }

        public void ChannelUp()
        {
            DeviceAdapter.ChannelUp();
        }

        public void TogglePower()
        {
            DeviceAdapter.TogglePower();
        }

        public void VolumeDown()
        {
            DeviceAdapter.VolumeDown();
        }

        public void VolumeUp()
        {
            DeviceAdapter.VolumeUp();
        }
    }
}
