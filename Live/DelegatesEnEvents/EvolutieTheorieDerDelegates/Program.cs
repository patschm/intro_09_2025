namespace EvolutieTheorieDerDelegates;

delegate int MathDel(int s, int t);


internal class Program
{
    static void Main(string[] args)
    {

        // Framework 1.0/1.1 2002/2003
        MathDel m1 = new MathDel(TelOp);
        int result = m1(1, 2);

        // Framework 2.0  2005
        MathDel m2 = TelOp;
        result = m2(2, 3);

        int c = 100;
        MathDel m3 = delegate (int a, int b)
        {
            return a + b + c;
        };

        result = m3(3, 4);

        // Framework 3.0/3.5
        // Lambda expressie
        MathDel m4 = (a, b) => a + b + c;
        result = m4(4, 5);


        // Functions
        Func<int, int, int> m5 = TelOp;
        result = m5(6,7);

        // Procedures
        Action<string> a = Console.WriteLine;
        a("Hello");


        Func<int, int, int> m6 = (a, b) => a + b;



        Console.WriteLine(result);


        int TelOp(int a, int b)
        {
            return a + b + c;
        }

        DoeIets();
    }

    private static void DoeIets()
    {
        //throw new NotImplementedException();
    }

    static int TelOp(int a, int b)
    {
        return a + b;
    }
}
