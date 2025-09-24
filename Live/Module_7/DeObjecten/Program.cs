namespace DeObjecten;

internal class Program
{
    static void Main(string[] args)
    {
        // Big bang
        //Lamp led = new Lamp();
        //led.Color = ConsoleColor.Red;
        //led.Aan();
        
        //led.Uit();

        // Generaliseren
        Lamp tl = new TL { Color = ConsoleColor.Yellow };
        tl.Aan();
   
        tl.Uit();


        // lader1 is een object
        Oplader lader1 = new Oplader(tl)
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

