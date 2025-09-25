
using System.Net;

namespace TheCompagny;

internal class Jordi : Werknemer
{
    public override void DoetIets()
    {
        MaaktGedroogteRotsen();
    }
    public void MaaktGedroogteRotsen()
    {
        Console.WriteLine("Jordi maakt gedroogte rotsen");
    }
}
