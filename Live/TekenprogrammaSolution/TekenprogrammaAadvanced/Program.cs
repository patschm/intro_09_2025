namespace Tekenprogramma;

internal class Program
{
    static void Main(string[] args)
    {
        Canvas canvas = new Canvas();

        Cirkel c1 = new Cirkel { Location = new Position { X = 100, Y = 200 }, Straal = 200 };
        canvas.VoegToe(c1);
        Cirkel c2 = new Cirkel { Location = new Position { X = 200, Y = 200 }, Straal = 100 };
        canvas.VoegToe(c2);

        Rechthoek r1 = new Rechthoek { Location = new Position { X = 100, Y = 100 }, Hoogte = 100, Breedte=200 };
        canvas.VoegToe(r1 );
        Rechthoek r2 = new Rechthoek { Location = new Position { X = 10, Y = 10 }, Hoogte = 50, Breedte = 150 };
        canvas.VoegToe(r2);

        Driehoek d1 = new Driehoek { Location = new Position { X = 50, Y = 100 }, Hoogte = 100, Basis = 200, Hoek=83F };
        canvas.VoegToe(d1 );
        Driehoek d2 = new Driehoek { Location = new Position { X = 250, Y = 150 }, Hoogte = 200, Basis = 200, Hoek = 60F };
        canvas.VoegToe(d2 );
    }
}
