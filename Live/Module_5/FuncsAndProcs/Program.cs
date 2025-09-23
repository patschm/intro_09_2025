namespace FuncsAndProcs;

internal class Program
{
    static void Main(string[] args)
    {
        string name =  RestaurantChoice();
        PrintCustomerName(name);
        Customer.PrintCustomerName(name);

        double result = TelOp(3, 4, 5.5);
        Console.WriteLine(result);
    }

    // Procedure. Herkenbaar aan de void ervoor.
    // string name is een speciale locale variabele
    static void PrintCustomerName(string name)
    {
        //string name;
        Console.WriteLine(name);
    }

    // Functies geven altijd wat terug. Jij MOET een waarde terug geven.
    static string RestaurantChoice()
    {
        Console.WriteLine("Waar wilt u gaan eten?");
        ShowRestaurants();
        string name = AskUserTheRestaurantChoice();

        return name;
    }

    static void ShowRestaurants()
    {
        Console.WriteLine("1) Bij Dagmar");
        Console.WriteLine("2) Woody's");
        Console.WriteLine("3) Fong Shou");
    }

    static string AskUserTheRestaurantChoice()
    {
        Console.WriteLine("Kies 1,2 of 3");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                return "Bij Dagmar";
            case "2":
                return "Woody's";
            case "3":
                return "Fong Shou";
            default:
                return "Snackbar Bennies";
        }
    }

    static double TelOp(int a, long b, double c)
    {
        double result  = a + b + c;
        return result;
    }
}
