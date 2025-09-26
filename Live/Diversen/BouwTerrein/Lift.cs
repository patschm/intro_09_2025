namespace BouwTerrein;

internal class Lift
{
    private int _currentFloor = 0;
    
    public int CurrentFloor
    {
        get { return _currentFloor; }
    }
    public void Call(int floor)
    {
        Console.WriteLine($"De lift zoemt naar de {floor}e etage");
        _currentFloor = floor;
    }
}