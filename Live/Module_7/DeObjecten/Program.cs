namespace DeObjecten;



internal class Program
{
    static void Main(string[] args)
    {
        // Big bang
        Lamp led = new Lamp();
        led.Color = ConsoleColor.Red;
        // lader1 is een object
        Oplader lader1 = new Oplader(led)
        { // Property initializers
            Ingangsspanning = 240, 
            Uitgansspanning = 24,
            Weerstand = 1000
        };
       // lader1.Vermogen = 600;

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
    //private int ingansspanning = 220;
    //private int uitgangsspanning;
    private int vermogen = 200;
    //private int weerstand;
    private bool isAangesloten = false;
    private Lamp _led;

    // Gecontroleerde toegang. Ofwel encapsulation
    // Properties. Het cosmeyische jasje om de Set en Get methodes verderop
    public int Vermogen
    {
        get
        {
            return vermogen;
        }
        set
        {
            if (value >= 0 && value <= 1000)
            {
                vermogen = value;
            }
        }
    }

    // Auto generating property. Genereert zijn eigen private field.
    public int Ingangsspanning { get; set; } = 220;
    public int Uitgansspanning { get; set; }
    public int Weerstand { get; set; } = 500;
    public bool IsAangesloten
    {
        get { return isAangesloten; }
        private set { isAangesloten = value; }
    }



    // Niet gebruikelijk in .NET, maar opzich wel correct.
    //public void SetVermogen(int amount)
    //{
    //    if (amount >= 0 && amount <= 1000)
    //    {
    //        vermogen = amount;
    //    }
    //}
    //public int GetVermogen()
    //{
    //    return vermogen;
    //}


    // Constructor.
    // Hiermee geef ik fields een initiele waarde
    public Oplader(Lamp led)
    {
        //this.led = led;
        _led = led;
    }

    // Methods. Hierin definieer ik gedrag
    // Kan ook public of private zijn.
    private void Verwarm()
    {
        Console.WriteLine("De oplader wordt warm");
    }

    private void Laden()
    {
        Console.WriteLine($"Begint te laden met een maximaal vermogen van {Vermogen}");
    }

    private void Bromt()
    {
        Console.WriteLine("Begint te brommen");
        Console.Beep(70, 5000);
    }
    // 
    public void Start()
    {
        _led.Aan();
        Console.WriteLine($"Oplader ({Ingangsspanning}Volt) begint nu met laden");
        IsAangesloten = true;
        Laden();
        Bromt();
        Verwarm();

    }
    public void Stop()
    {
        Console.WriteLine("De oplader is klaar");
        IsAangesloten = false;
        _led.Uit();
    }

}

class Lamp
{
    public ConsoleColor Color { get; set; }

    public void Aan()
    {
        Console.BackgroundColor = Color;
        Console.WriteLine("Het lampje brandt");
    }

    public void Uit()
    {
        Console.ResetColor();
        Console.WriteLine("Het lampje is uit");
    }
}
