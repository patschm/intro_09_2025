
namespace TheCompagny;

internal class ACME
{
    private List<IAcmeContract> _werknemer = new();

    public void Hire(IAcmeContract werknemer)
    {
        _werknemer.Add(werknemer);
    }
    public void StartProduction()
    {
        Console.Beep(2000, 1000);
        Console.WriteLine("ACME gaat produceren");
        foreach(IAcmeContract w in _werknemer) 
            w.Werk();
    
    }
}
