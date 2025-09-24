
namespace Tekenprogramma;

internal class Cirkel
{
    public Position Location { get; set; } =  new Position { X = 0, Y = 0 };
    private int _straal;

    public int Straal
    {
        get { return _straal; }
        set 
        { 
            if(value > 0) 
                _straal = value; 
        }
    }

    // int Straal { get; set; }

    public void Teken()
    {
        Console.WriteLine($"Cirkel op positie {Location.Show()} met straal {Straal}");
    }
}
