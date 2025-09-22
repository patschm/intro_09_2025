namespace D1_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hier mag ik variabelen declareren.
            byte age;
            age = 2; // Literal
            long yearsBeforeEarth;
            //checked
            //{
                int ages = int.Parse("1000") * 3_000_000;
                Console.WriteLine(ages);
            //}

            char kar = 'a'; // Literal
            // Scope. Bepaalt levensduur variablen
            {
                string name2 = "Patrick";
                Console.WriteLine(name2);
            }
            //Console.WriteLine(name);
            Console.WriteLine("Geef uw naam");
            string  name = Console.ReadLine();
            Console.WriteLine(name);

            bool isWaar = true;

            const double pi = 3.14;

            //pi = 6.28; // Mag niet.
        }
    }
}
