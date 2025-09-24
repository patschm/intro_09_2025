namespace Tekenprogramma;

internal class Rechthoek
{
    public Position Location { get; set; }
    public int Hoogte { get; set; }
    public int Breedte { get; set; }

    public void Teken()
    {
        Console.WriteLine($"Rechthoek op positie {Location.Show()} met breedte {Breedte}, hoogte {Hoogte}");
    }
}
