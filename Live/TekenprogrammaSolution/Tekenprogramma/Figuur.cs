namespace Tekenprogramma;

internal abstract class Figuur
{
    public Position Location { get; set; } = new Position { X = 0, Y = 0 };

    public abstract void Teken();
}
