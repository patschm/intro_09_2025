namespace HetCern;

delegate int CalDel(int a, int b);

internal class WillemKlein
{
    public void Bereken(CalDel del, int a, int b)
    {
        Console.WriteLine("Willem Klein gaat rekenen");

        int result = del(a, b);
        Console.WriteLine($"Willem kraait: Het antwoord is {result}");
    }
}
