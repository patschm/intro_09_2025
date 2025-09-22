using System.Threading.Channels;

namespace Loopings_for;

internal class Program
{
    static void Main(string[] args)
    {
        // For loop
        // block 1: initializer
        // block 2: Conditie check (verborgen if-statement)
        // block 3: Wordt aan het einde van iedere iteratie aangroepen.
        // De for loop gebruik je als je exact!! weet hoe vaak iets moet worden uitgevoerd.
        int x = 0;
        for (x = 0; x < 20; x++)
        {
            if (x % 2 == 1) continue;
            Console.WriteLine($"{x}e iteratie");
            //if (x >= 20) break;
        }

        Console.WriteLine(x);
    }
}
