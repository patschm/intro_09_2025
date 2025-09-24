namespace Tekenprogramma;

internal class Rechthoek: Figuur
{
    public int Hoogte { get; set; }
    public int Breedte { get; set; }

    public override void Teken()
    {
        Console.WriteLine($"Rechthoek op positie {Location.Show()} met breedte {Breedte}, hoogte {Hoogte}");
    }
}
