namespace Inheritance;

// TODO 2a: Inherit from Vehicle and remove redundant code.
internal class Bicycle : Vehicle
{
    public int NumberOfGears { get; set; } = 10;

    public Bicycle(): base(50)
    {
        
    }
    // TODO 4a: Override the methods below where necessary.
    public override void Throttle()
    {
        CurrentSpeed++;
    }
    public override void Brake()
    {
        CurrentSpeed--;
    }
    public override void DisplayStatus()
    {
        Console.WriteLine($"The bicycle with {NumberOfGears} gears rides with a speed of {CurrentSpeed}km/h");
    }
}
