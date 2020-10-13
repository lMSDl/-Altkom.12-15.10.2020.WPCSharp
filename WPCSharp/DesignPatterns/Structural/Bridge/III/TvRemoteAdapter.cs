using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Bridge.III
{
    public class TvRemoteAdapter : IRemote
    {
        public TvRemote _tvRemote;

        public TvRemoteAdapter(TvRemote tvRemote)
        {
            _tvRemote = tvRemote;
        }

        public void ChannelDown()
        {
            _tvRemote.ChannelDown();
        }

        public void ChannelUp()
        {
            _tvRemote.ChannelUp();
        }

        public void TogglePower()
        {
            _tvRemote.TogglePower();
        }

        public void VolumeDown()
        {
            _tvRemote.VolumeDown();
        }

        public void VolumeUp()
        {
            _tvRemote.VolumeUp();
        }
    }
}
