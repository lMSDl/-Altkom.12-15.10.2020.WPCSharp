using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Bridge.III
{
    public class HiFiRemoteAdapter : IRemote
    {
        public HiFiRemote _hiFiRemote;
        public bool _powerState;

        public HiFiRemoteAdapter(HiFiRemote hiFiRemote)
        {
            _hiFiRemote = hiFiRemote;
        }

        public void ChannelDown()
        {
        }

        public void ChannelUp()
        {
        }

        public void TogglePower()
        {
            if (_powerState)
                _hiFiRemote.PowerOn();
            else
                _hiFiRemote.PowerOn();
        }

        public void VolumeDown()
        {
            _hiFiRemote.VolumeDown();
        }

        public void VolumeUp()
        {
            _hiFiRemote.VolumeUp();
        }
    }
}
