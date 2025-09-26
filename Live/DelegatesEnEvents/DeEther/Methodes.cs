namespace DeEther;

static class Methodes
{
    public static void ViaEther(string msg)
    {
        Console.WriteLine($"Via Ether ontvangen: {msg}");
    }
    public static void ViaSMS(string msg)
    {
        Console.WriteLine($"Via SMS ontvangen: {msg}");
    }
    public static void ViaMail(string msg)
    {
        Console.WriteLine($"Via Mail ontvangen: {msg}");
    }
    public static void ViaRooksignalen(string msg)
    {
        Console.WriteLine($"Via rooksignalen ontvangen: {msg}");
    }
    public static void ViaPostduif(string msg)
    {
        Console.WriteLine($"Via Postduif ontvangen: {msg}");
    }
}
