
namespace TheCompagny;

// RockOMatic _IMPLEMENTEERT_ (DUS NIET ERFT) de interface IAcmeContract
internal class RockOMatic : IAcmeContract
{
    public  void DoetIets()
    {
        Console.WriteLine("RockOMatic maakt opblaasbare rotsen");
    }

    public void Werk()
    {
        DoetIets();
    }
}
