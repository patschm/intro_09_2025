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
            string name = "Patrick";
            Console.WriteLine(name);
            Console.WriteLine("Geef uw naam");
            name = Console.ReadLine();
            Console.WriteLine(name);
        }
    }
}
