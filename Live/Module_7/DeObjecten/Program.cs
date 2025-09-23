namespace DeObjecten;



internal class Program
{
    static void Main(string[] args)
    {
        // Big bang
        // lader1 is een object
        Oplader lader1 = new Oplader();
        lader1.led = new Lamp();
        lader1.led.color = ConsoleColor.Red;
        lader1.ingansspanning = 230;
        lader1.uitgangsspanning = 24;
        lader1.weerstand = 1000;
        lader1.vermogen = 65;
        lader1.isAangesloten = false;

        lader1.Start();

        lader1.Stop();
        // Big crunch
    }
}


// Blauwdruk van een object.
// Custom type
class Oplader
{
    // Fields. Hierin slaan we eigenschappen op
    // Kunnen public of private zijn
    public int ingansspanning;
    public int uitgangsspanning;
    public int vermogen;
    public int weerstand;
    public bool isAangesloten;
    public Lamp led;

    // Methods. Hierin definieer ik gedrag
    // Kan ook public of private zijn.
    private void Verwarm()
    {
        Console.WriteLine("De oplader wordt warm");
    }

    private void Laden()
    {
        Console.WriteLine($"Begint te laden met een maximaal vermogen van {vermogen}");
    }

    private void Bromt()
    {
        Console.WriteLine("Begint te brommen");
        Console.Beep(70, 5000);
    }
    // 
    public void Start()
    {
        led.Aan();
        Console.WriteLine("Oplader begint nu met laden");
        isAangesloten = true;
        Laden();
        Bromt();
        Verwarm();
        
    }
    public void Stop()
    {
        Console.WriteLine("De oplader is klaar");
        isAangesloten = false;
        led.Uit();
    }
    
}

class Lamp
{
    public ConsoleColor color;

    public void Aan()
    {
        Console.BackgroundColor = color;
        Console.WriteLine("Het lampje brandt");
    }

    public void Uit()
    {
        Console.ResetColor();
        Console.WriteLine("Het lampje is uit");
    }
}
