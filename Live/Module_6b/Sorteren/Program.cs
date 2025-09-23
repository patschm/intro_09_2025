
namespace Sorteren;

internal class Program
{
    static void Main(string[] args)
    {
        int[] nummers = [3, 2, 5, 8, 7, 1, 7, 9, 8, 2, 4];
        ShowNumbers(nummers);
        BubbleSort(nummers);
        ShowNumbers(nummers);
        Console.ReadLine();
    }

    static void ShowNumbers(int[] nummers)
    {
        foreach (int num in nummers)
        {
            Console.Write($"{num}, ");
        }
        Console.WriteLine();
    }

    static void BubbleSort(int[] numbers)
    {
        bool isSwapped;// = false;

        do
        {
            isSwapped = false;
            for (int idx = 0; idx < numbers.Length - 1; idx++)
            {
                int left = numbers[idx];
                int right = numbers[idx + 1];
                if (left > right)
                {
                    numbers[idx] = right;
                    numbers[idx + 1] = left;
                    isSwapped = true;
                }
            }
        }
        while (isSwapped);
    }
}
