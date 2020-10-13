namespace DesignPatterns.Structural.Bridge.III
{
    public interface IRemote
    {
        void ChannelDown();

        void ChannelUp();

        void TogglePower();

        void VolumeDown();

        void VolumeUp();
    }
}
