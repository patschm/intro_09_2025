
using System.IO;

namespace Tekenprogramma;

internal class Driehoek
{
    public Position Location { get; set; }
    public int Basis { get; set; }
    public int Hoogte { get; set; }
    public float Hoek { get; set; }

    public void Teken()
    {
        Console.WriteLine($"Driehoek op positie {Location.Show()} met basis {Basis}, hoogte {Hoogte} en hoek: {Hoek}");
    }
}
