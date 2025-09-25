using TekenprogrammaAdvanced;

namespace Tekenprogramma;

internal class Rechthoek: Figuur
{
    public int Hoogte { get; set; }
    public int Breedte { get; set; }

    public override void Teken(IDrawable dev)
    {
        dev.DrawRectangle(this);
    }
}
