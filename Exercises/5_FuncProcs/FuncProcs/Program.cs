namespace FuncProcs;

// TODO 1a: Can you define a function here? (yes/no) 
// no

// TODO 2a: Can you call a function or procedure here? (yes/no)
// no
internal class Program
{
    // TODO 1b: Can you define a function here? (yes/no) 
    // yes

    // TODO 2b: Can you call a function or procedure here? (yes/no)
    // no
    static void Main(string[] args)
    {
        // TODO 1c: Can you define a function here? (yes/no) 
        // no (for the moment)

        // TODO 2c: Can you call a function or procedure here? (yes/no)
        // Yes
        {
            // TODO 1d: Can you define a function here? (yes/no) 
            // no

            // TODO 2d: Can you call a function or procedure here? (yes/no)
            // yes
        }

        DisplayWelcome();
        GenericMessage("Hello World");
        int number = RandomNumber();
        Console.WriteLine(number);
        number = RandomNumber(10, 100);
        Console.WriteLine(number);
        DisplayInfo("Henk", 34, DateTime.Now.AddYears(-34), "Ubach over worms");

        DateTime date = CreateDateTime(1993, 4, 12);
        Console.WriteLine(date);
    }

    // TODO 3: Define a procedure that displays a welcome message (Console.WriteLine("Welcome"))
    // and call the procedure in the appropriate place.
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome");
    }

    // TODO 4: Define a procedure that displays a generic message, specified by the caller (Console.WriteLine($"External data: {xxx}"))
    // and call the procedure in the appropriate place.
    static void GenericMessage(string message) 
    {
        Console.WriteLine($"External data: {message}");
    }


    // TODO 5: Create a function that generates and returns a random number
    // and call the function in the appropriate place and show the result.
    static int RandomNumber()
    {
        return Random.Shared.Next();
    }

    // TODO 6: Create a function that generates and returns a random number between a certain range, specified by the caller
    // and call the function in the appropriate place and show the result.
    static int RandomNumber(int start, int exclusiveEnd)
    {
        return Random.Shared.Next(start, exclusiveEnd);
    }

    // TODO 7: Define a procedure that accept 4 inputs: a name, an age, a birthdate and a birth place.
    // Print the information to the screen.
    // Call the function in the appropriate place
    static void DisplayInfo(string name, byte age, DateTime birthDate, string cityBirth)
    {
        Console.WriteLine($"{name}, {age}, {birthDate.ToLongDateString()}, {cityBirth}");
    }

    // TODO 8: Define a function that accept 3 inputs: year, month, day, that returns a DateTime.
    // Call the function in the appropriate place and show the result.
    static DateTime CreateDateTime(int year, int month, int day)
    {
        return new DateTime(year, month, day);
    }


    static void DoSomething()
    {
        // TODO 2e: Can you define a function here? (yes/no) 
        // no

        // TODO 2e: Can you call a function or procedure here? (yes/no)
        //yes
    }

    // TODO 1f: Can you define a function here? (yes/no) 
    // yes

    // TODO 2f: Can you call a function or procedure here? (yes/no)
    // no
}
// TODO 1g: Can you define a function here? (yes/no) 
// no

// TODO 2g: Can you call a function or procedure here? (yes/no)
// no
