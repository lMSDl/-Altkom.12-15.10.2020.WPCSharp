namespace DesignPatterns.Structural.Bridge.III
{
    public class Client
    {
        public static void Execute()
        {
            var remote = new Remote();
            var tvRemoteAdapter = new TvRemoteAdapter(new TvRemote());
            remote.DeviceAdapter = tvRemoteAdapter;

            remote.TogglePower();
            remote.ChannelDown();
            remote.VolumeUp();

            var hiFiRemoteAdapter = new HiFiRemoteAdapter(new HiFiRemote());
            remote.DeviceAdapter = hiFiRemoteAdapter;
            
            remote.TogglePower();
            remote.ChannelDown();
            remote.VolumeUp();

            remote.DeviceAdapter = tvRemoteAdapter;
            remote.TogglePower();

            remote.DeviceAdapter = hiFiRemoteAdapter;
            remote.TogglePower();
        }
    }
}
