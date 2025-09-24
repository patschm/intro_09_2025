namespace Tekenprogramma;

internal class Position
{
    public int X { get; set; }
    public int Y { get; set; }

    public string Show()
    {
        return $"({X}, {Y})";
    }
}
