namespace Inheritance;

// TODO 2c: Inherit from Vehicle and remove redundant code.
internal class Lorry: Vehicle
{
    public int MaxLoad { get; set; } = 20_000;

    public Lorry(): base(120)
    {
        
    }

    // TODO 4b: Override the methods below where necessary.
    public override void Throttle()
    {
        CurrentSpeed += 8;
    }
    public override void Brake()
    {
        CurrentSpeed -= 8;
    }
    public override void DisplayStatus()
    {
        Console.WriteLine($"The lorry with a maximum load of {MaxLoad}kg drives with a speed of {CurrentSpeed}km/h");
    }
}
