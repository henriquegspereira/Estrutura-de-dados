Console.WriteLine("Ordenação com Bubble Sort");

string[] arrStrings = new string[] {
    "Ana",
    "Carlos",
    "Zenaide",
    "João",
    "Beatriz",
    "Maria",
    "Pedro",
    "Juliana",
    "Gustavo"
};

foreach (var nome in arrStrings)
{
    Console.Write($"[{nome}] ");
}

var arrOrdered = VetorStringBubble.BubbleSortOrder.Sort<string>(arrStrings);

Console.WriteLine("");
Console.WriteLine("\n*****************");
Console.WriteLine("Vetor ordenado: ");
Console.WriteLine("");
foreach (var nome in arrOrdered)
{
    Console.Write($"[{nome}] ");
}