namespace DieAndereLoops;

internal class Program
{
    static void Main(string[] args)
    {
        // De while loop.
        // Wordt 0 of meer keer uitgevoerd
        // Ideaal voor tabellen en files of andere dingen die potentieel leeg kunnen zijn.

        int rndNumber = 0;

        while ((rndNumber = Random.Shared.Next(0, 20)) != 0)
        {
            Console.WriteLine($"Het getal is {rndNumber}");
        }
        Console.WriteLine(rndNumber);


        // do-while loop
        // Wordt een of meer keer uitgevoerd.

        do
        {
            Console.WriteLine("Geef het magische getal");
            string snumber = Console.ReadLine();
            rndNumber = int.Parse(snumber);
            Console.WriteLine($"Is het echt {rndNumber}?");
        }
        while (rndNumber != 42);

        Console.WriteLine(rndNumber);
    }
}
