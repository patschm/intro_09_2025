using Standards;

namespace Yunex;

public class Detectielus
{
    private List<IDevice> devices = new List<IDevice>();

    public void Connect(IDevice device)
    {
        devices.Add(device);
    }

    public void GaatAf()
    {
        Console.WriteLine("De detectielus ziet iets...");
        foreach (IDevice device in devices) 
        {
            device.Activate();
        }
    }
}
