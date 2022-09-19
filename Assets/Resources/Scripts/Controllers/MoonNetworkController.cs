
public class MoonNetworkController : NetworkController
{
    private void Start()
    {
        openPort(NetworkInfoStore.MOON_UDP_PORT);
        connectToPort(NetworkInfoStore.SUN_UDP_PORT);
        sendMessage(TagStore.CONNECTED);
    }
}
