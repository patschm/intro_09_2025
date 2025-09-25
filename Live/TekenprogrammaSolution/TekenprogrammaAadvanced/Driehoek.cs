
using System.IO;
using TekenprogrammaAdvanced;

namespace Tekenprogramma;

internal class Driehoek: Figuur
{
    public int Basis { get; set; }
    public int Hoogte { get; set; }
    public float Hoek { get; set; }

    public override void Teken(IDrawable dev)
    {
        dev.DrawTriangle(this);
    }
}
