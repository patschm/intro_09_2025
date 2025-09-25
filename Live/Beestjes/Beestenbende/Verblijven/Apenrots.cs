
using Beestenbende.Dieren;

namespace Beestenbende.Verblijven;

internal class Apenrots : Verblijf
{
    protected override bool Check(Dier d)
    {
        return d is Aap;
    }
}
