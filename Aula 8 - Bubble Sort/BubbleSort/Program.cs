// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ordenação com Bubble Sort");

int[] arrNumbers = new int[] { 99, 50, -24, 0, 1 };

foreach (var number in arrNumbers)
{
    Console.Write($"[{number}] ");
}

var arrOrdered =
    BubbleSort.BubbleSortOrder.Sort(arrNumbers);

Console.WriteLine("");
Console.WriteLine("\n*****************");
Console.WriteLine("Vetor ordenado: ");
Console.WriteLine("");
foreach (var number in arrOrdered)
{
    Console.Write($"[{number}] ");
}