namespace ConsoleApp1;

// Een delegate is een blauwdruk van een functie.
// Een delegate is een type definitie
delegate void Exec();

internal class Isabella
{
    public void Execute(Exec iets)
    {
        Console.WriteLine("Isaballa voer nu uit:");
        iets();
    }
}
