namespace Arrays;

internal class Program
{
    static void Main(string[] args)
    {
        //int[] nummers = new int[10];
        //nummers[0] = 1;
        //nummers[1] = 2;
        //nummers[2] = 3;

        //nummers[9] = 10;

        //[] nummers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //int[] nummers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //int[] nummers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] nummers = [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ];

        for (int i = 0; i < nummers.Length ; i++ )
        {
            int waarde = nummers[i];
            Console.WriteLine(waarde);
        }

        foreach (int waarde in nummers)
        {
            Console.WriteLine(waarde);
        }

        //int[][] jagged = new int[10][];
        //jagged[0] = new int[10];
        int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        matrix[0, 1] = 5;

        //Roeiboot[]
    }
}
