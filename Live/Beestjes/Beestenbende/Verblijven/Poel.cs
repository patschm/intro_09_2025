using Beestenbende.Dieren;

namespace Beestenbende.Verblijven;

internal class Poel : Verblijf
{
    protected override bool Check(Dier d)
    {
        return d is Amfibi || d is Vis;
    }
}
