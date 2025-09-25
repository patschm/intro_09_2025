
using Beestenbende.Dieren;

namespace Beestenbende.Verblijven;

internal class Aquarium : Verblijf
{
    protected override bool Check(Dier d)
    {
        return d is Vis;
    }
}
