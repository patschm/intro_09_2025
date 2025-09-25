using Tekenprogramma;

namespace TekenprogrammaAdvanced;

internal class ConsoleDevice : IDrawable
{
    public void DrawCircle(Cirkel c)
    {
        Console.WriteLine($"Cirkel op positie {c.Location.Show()} met straal {c.Straal}");
    }

    public void DrawRectangle(Rechthoek r)
    {
        Console.WriteLine($"Rechthoek op positie {r.Location.Show()} met breedte {r.Breedte}, hoogte {r.Hoogte}");

    }

    public void DrawTriangle(Driehoek d)
    {
        Console.WriteLine($"Driehoek op positie {d.Location.Show()} met basis {d.Basis}, hoogte {d.Hoogte} en hoek: {d.Hoek}");

    }
}
