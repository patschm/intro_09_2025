namespace BouwTerrein;

internal class Etage
{
    private readonly int _etagenummer;
    private static Lift _elevator = new Lift();

    public int EtageNummer
    {
        get { return this._etagenummer; }
    }

    public static void DisplayElevatorStatus()
    {
        Console.WriteLine($"De lift staat nu op de {_elevator.CurrentFloor}e verdieping");
    }
    public void CallElevator()
    {
        Etage._elevator.Call(EtageNummer);
    }
    public Etage(int etagenummer)
    {
        _etagenummer = etagenummer;
    }
}
