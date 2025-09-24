
namespace Tekenprogramma;

internal class Cirkel : Figuur
{
    
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

    public override void Teken()
    {
        Console.WriteLine($"Cirkel op positie {Location.Show()} met straal {Straal}");
    }
}
