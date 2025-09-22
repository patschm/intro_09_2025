namespace D2_Operators;

internal class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 20;

        int c = (a + b) * 2;

        a = a + 10;
        a += 10;
        

        // a = a + 1'
        //++a;
        Console.WriteLine(a++);
        Console.WriteLine(a);

        float d = 6 / 4F;

        Console.WriteLine(d);

        int e = b % 3;
        Console.WriteLine(e);


        bool isGelijk = a == b;
        Console.WriteLine(isGelijk);

        bool isGroter = a >= b;


    }
}
