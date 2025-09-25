using Standards;

namespace DoomsdayPreppers;

public class Valkuil : IDevice
 {
    public void Activate()
    {
        Open();
    }

    public void Open()
    {
        Console.WriteLine("De valkuil opent en scherpe spiezen worden zichtbaar");
    }
}
