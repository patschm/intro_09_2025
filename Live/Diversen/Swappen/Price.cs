
namespace Swappen;

internal record struct Price(double price)
{

    public double Value { get => price; }
    public override string ToString()
    {
        return $"{price} euro";
    }
}
