
using Beestenbende.Dieren;

namespace Beestenbende.Verblijven;

internal class Steppe : Verblijf
{
    protected override bool Check(Dier d)
    {
        return d is Grazer;
    }
}
