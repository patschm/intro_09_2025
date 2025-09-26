namespace HetCern;

internal class Program
{
    static void Main(string[] args)
    {
        WillemKlein willemKlein = new WillemKlein();
        SimonVDMeer simonVDMeer = new SimonVDMeer();

        //willemKlein.Bereken(simonVDMeer.Add, 5, 6);
        //willemKlein.Bereken(simonVDMeer.Subtract, 7, 8);
        //willemKlein.Bereken(Multiply, 3, 4);

        CalDel c1 = simonVDMeer.Add;
        c1 = c1 + simonVDMeer.Subtract;
        c1 = c1 + simonVDMeer.Add;
        c1 = c1 + simonVDMeer.Subtract;
        c1 += Multiply;
        c1 -= Multiply;



        foreach (var c in c1.GetInvocationList()) 
        {
            Console.WriteLine(c.Method.Name);
        }

        int res = c1(1, 2);

        Console.WriteLine(res);
    }


    static int Multiply(int a, int b)
    {
        return a * b;
    }
}
