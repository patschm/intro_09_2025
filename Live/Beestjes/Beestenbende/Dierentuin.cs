
using Beestenbende.Verblijven;

namespace Beestenbende;

internal class Dierentuin
{
    private List<Verblijf> verblijven = new();

    public void Extend(Verblijf verblijf)
    {
        verblijven.Add(verblijf);
    }
    public void Open()
    {
        foreach (Verblijf verblijf in verblijven)
        {
            verblijf.Ram();
        }
    }
}
