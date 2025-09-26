
namespace BouwTerrein;

internal class Program
{
    //static List<int> ints = new List<int>();

    static void Stressen()
    {
        List<int> list = new List<int>();
        for (int i = 0; i < 1_000_000_000; i++)
        {
            list.Add(i);
        }
    }
    static void Main(string[] args)
    {
        //Stressen(); 
        //Etage._elevator.Call(-10);

        Complex c1 = new Complex { Real = 10, Imaginary = 20 };
        Complex c2 = new Complex { Real = 100, Imaginary = 200 };
        Console.WriteLine($"{c1}, {c2}");
        Complex c3 = c1 + c2; //Complex.TelOp(c1, c2);
        Console.WriteLine(c3);

        Console.WriteLine($"{c1}");
        DoeIets(c1);
        Console.WriteLine($"{c1}");

        Complex? cr = c1.Clone() as Complex;

        Complex ct = new Complex(c1);


        Etage[] flat = new Etage[40];
        for (int i = 0; i < flat.Length; i++)
        {
            flat[i] = new Etage(i + 1);
        }

        flat[32].CallElevator();

        foreach(var etage in flat)
        {
            //Etage.DisplayElevatorStatus();
        }
        Console.ReadLine();
    }

    private static void DoeIets(Complex cc)
    {
        cc.Real += 10000;
        cc.Imaginary += 1000;
    }
}
