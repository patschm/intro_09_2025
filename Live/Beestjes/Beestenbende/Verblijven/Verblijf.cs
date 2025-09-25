
using Beestenbende.Dieren;

namespace Beestenbende.Verblijven;

internal abstract class Verblijf
{
    private List<Dier> dieren = new();

    public void Ram()
    {
        foreach (var dier in dieren)
        {
            dier.MaakGeluid();
        }
    }
    public void Add(Dier d)
    {
        if (Check(d))
        {
            dieren.Add(d);
        }
        else
        {
            Console.WriteLine($"Een {d.GetType().Name} kan niet in een {this.GetType().Name}");
        }
    }
    protected abstract bool Check(Dier d);
 
}
