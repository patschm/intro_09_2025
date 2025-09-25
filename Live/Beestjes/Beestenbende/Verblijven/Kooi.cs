
using Beestenbende.Dieren;

namespace Beestenbende.Verblijven;

internal class Kooi : Verblijf
{
    protected override bool Check(Dier d)
    {
        return d is Kat;
    }
}
