namespace D3_JumpForward;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wie ben jij?");
        string naam = null;// Console.ReadLine();


        //if (naam != "")
        if (!string.IsNullOrEmpty(naam))
        {
            Console.WriteLine("U bent " + naam);
            Console.WriteLine("U bent {0}", naam);
            Console.WriteLine($"U bent {naam}");
        }
        else if (naam == "")
        {
            Console.WriteLine("U bent anoniem");
        }
        else
        {
            Console.WriteLine("Hier kan ik echt niks mee");
        }
        Console.WriteLine("En hier gaan we verder");


        int x = Random.Shared.Next(1, 60);

        switch (x)
        {
            case 1:
                Console.WriteLine("Een");
                break;
            case 2:
                Console.WriteLine("Twee");
                break;
            case 3:
                Console.WriteLine("Drie");
                break;
            case 4:
                Console.WriteLine("Vier");
                break;
            case 5:
                Console.WriteLine("Vijf");
                break;
            default:
                Console.WriteLine(x);
                break;
        }

        switch (x) {
            case int v when x > 20 && x < 30:
                Console.WriteLine($"Tussen 20 en 30 {v}");
                break;
            case > 40:
                Console.WriteLine(x);
                break;


        }

    }
}
