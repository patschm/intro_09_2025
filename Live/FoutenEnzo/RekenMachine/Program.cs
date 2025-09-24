


namespace RekenMachine;

internal class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        try
        {
            int a = AskNumber("A");
            int b = AskNumber("B");
            // int result = TelOp(a, b);
            try
            {
                double result = calc.TelDoor(a, b);
                Console.WriteLine($"Het antwoord is {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Delen door 0 is flauwekul");
            }
        }
        catch(DomeinException de)
        {
            Console.WriteLine("Jammer. Neem contact op met Support met onderstaande info");
            Console.WriteLine($"{de.Message} met A={de.A} en B={de.B}") ;
            Console.WriteLine(de.StackTrace );
           
        }
        catch (Exception ex)
        {
            Console.WriteLine("Helaas. Neem contact op met support met de onderstaande melding");
            Console.WriteLine(ex);

        }
    }

    private static int TelOp(int a, int b)
    {
        return a / b;
    }

    private static int AskNumber(string label)
    {
        do
        {
            Console.WriteLine($"Geef getal {label}");
            string num = Console.ReadLine();
            try
            {
                int number = int.Parse(num);
                return number;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"{num} is geen geldig getal");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Het getal miet tussen {int.MinValue} en {int.MaxValue} liggen");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Geen idee. Neem contact op met support");
            }
        }
        while (true);
    }
}
