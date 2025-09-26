namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        Patrick patrick = new Patrick();
        Isabella isabella = new Isabella();

        //patrick.HaalDrankjes();
        isabella.Execute(patrick.HaalDrankjes);

    }
}
