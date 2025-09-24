namespace Inheritance;

// TODO 2b: Inherit from Vehicle and remove redundant code.
internal class Car: Vehicle
{
  
    public int NumberOfDoors { get; set; } = 3;

    public Car(): base(250)
    {
        
    }

    // TODO 4b: Override the methods below where necessary.
    public override void Throttle()
    {
        CurrentSpeed += 20;
    }
     public override void Brake()
    {
        CurrentSpeed -= 20;
    }
    public override void DisplayStatus()
    {
        Console.WriteLine($"The {NumberOfDoors}-doors car drives with a speed of {CurrentSpeed}km/h");
    }
}
