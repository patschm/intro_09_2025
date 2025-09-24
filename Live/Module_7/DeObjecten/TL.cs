
namespace DeObjecten;

// Dit is overerving. De TL erft van Lamp
// Je mag maar van een class tegelijk erven.
// Gebruik overerving alleen als je de vraag "Is het een" met droge ogen positief kunt beantwoorden.
// Is een TL een Lamp?
internal class TL : Lamp
{
    public int StartFrequentie { get; set; } = 4;

    // Met override maak ik het gedrag polymorf
    public  override void Aan()
    {
        for (int i = 0; i < StartFrequentie; i++) 
        {
            Console.ForegroundColor = Color;
            Console.WriteLine("Pling");
            Console.Beep(3000, 100);
            Console.Clear();
            //Task.Delay(500).Wait();
        }
        Console.BackgroundColor = Color;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"De TL brandt met {intensiteit}lm");
    }

    public override void Uit()
    {
        Console.ResetColor();
        Console.WriteLine("De TL is uit");
    }

    public TL()
    {
        intensiteit = 400;
    }
}
