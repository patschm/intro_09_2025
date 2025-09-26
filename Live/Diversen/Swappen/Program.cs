
using BouwTerrein;

namespace Swappen;

internal class Program
{
    public static object Roeiboot { get; private set; }

    static void Main(string[] args)
    {
        Product p1 = new Product { SellingPrice = new Price(233.5) };
        Verkoop(p1.SellingPrice);

        Price iets = p1.SellingPrice;


        Roeiboot b = new Roeiboot(10);
        Roeiboot a = new Roeiboot(20);
        //string a = 10.ToString();
        //string b = 20.ToString();

        Console.WriteLine($"a={a}, b={b}");
        Swappen(ref a, ref b );
        Console.WriteLine($"a={a}, b={b}");

        Complex<double> x = new Complex<double> { Real = 100, Imaginary = 200 };
    }

    private static void Verkoop(Price xxx)
    {
        Console.WriteLine(xxx);
    }

    private static void Swappen<T>(ref T aa, ref T bb)
    {
        T tmp = aa;
        aa = bb;
        bb = tmp;
    }



    //private static void Swappen(ref double aa, ref double bb)
    //{
    //    double tmp = aa;
    //    aa = bb;
    //    bb = tmp;
    //}
    //private static void Swappen(ref float aa, ref float bb)
    //{
    //    float tmp = aa;
    //    aa = bb;
    //    bb = tmp;
    //}
    //private static void Swappen(ref long aa, ref long bb)
    //{
    //    long tmp = aa;
    //    aa = bb;
    //    bb = tmp;
    //}
    //private static void Swappen(ref int aa, ref int bb)
    //{
    //    int tmp = aa;
    //    aa = bb;
    //    bb = tmp;
    //}
}
