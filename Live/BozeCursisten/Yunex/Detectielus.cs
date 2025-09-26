using Standards;

namespace Yunex;

public delegate void DetectionHandler();

public class Detectielus
{
    private List<IDevice> devices = new List<IDevice>();
    private DetectionHandler handlers = default;
    public event DetectionHandler Detect;
    public event EventHandler Detect2;


    public void Connect(IDevice device)
    {
        devices.Add(device);
    }
    public void Connect(DetectionHandler device)
    {
        handlers += device;
    }

    public void GaatAf()
    {
        Console.WriteLine("De detectielus ziet iets...");
        foreach (IDevice device in devices) 
        {
            device.Activate();
        }

        handlers();

        Detect();

        //Detect2(this, EventArgs.Empty);
    }
}
