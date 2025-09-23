namespace AndereCollecties;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();

        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);
        list.Add(6);
        list.Add(7);
        list.Add(8);
        list.Add(9);
        list.Add(10);

        for (int i = 0; i < list.Count; i++) 
        {
            Console.WriteLine(list[i]);
        }

        foreach(int val in list)
        {
            Console.WriteLine(val);
        }

        Dictionary<string, int> lookup = new Dictionary<string, int>();
        lookup.Add("een", 1);
        lookup.Add("twee", 2);
        lookup.Add("drie", 3);

        Console.WriteLine(lookup["twee"]);
    }
}
