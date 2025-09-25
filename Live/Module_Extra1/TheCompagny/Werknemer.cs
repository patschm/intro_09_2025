
namespace TheCompagny;

internal class Werknemer : Persoon, IAcmeContract
{
    public virtual void DoetIets()
    {
        Console.WriteLine("Werknemer doet iets");
    }

    public void Werk()
    {
        DoetIets();
    }
}
