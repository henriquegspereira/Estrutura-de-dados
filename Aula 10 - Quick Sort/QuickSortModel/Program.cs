using System;
using QuickSortModel;

class Program {

    public static void Main()
    {
        int[] Lista = { 5, 7, 3, 0, 9, 1 };

        QuickSort.Sort(Lista);

        Console.WriteLine(string.Join(", ", Lista));
    }

}