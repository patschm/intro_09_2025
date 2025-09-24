namespace Inheritance;

// TODO 1: Examine this class, Bicycle, Car and Lorry
internal class Vehicle
{
    private readonly int MAX_SPEED = 100;
    private int currentSpeed;

    public int CurrentSpeed 
    { 
        get
        {
            return currentSpeed;
        }
        set
        {
            if (value <= MAX_SPEED && value >= 0)
            {
                currentSpeed = value;
            }
        }
    }

    public Vehicle()
    {
        
    }
    public Vehicle(int maxSpeed)
    {
        MAX_SPEED = maxSpeed;
    }

    // TODO 4: Make the methods below overridable
    public virtual void Throttle()
    {
        CurrentSpeed++;
    }
    public virtual void Brake()
    {
        CurrentSpeed--;
    }
    public virtual void DisplayStatus()
    {
        Console.WriteLine($"Vehicle drives with a speed of {CurrentSpeed}km/h");
    }
}
