int[] integerValues = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };

SelectionSort.SelectionSort.Sort(integerValues);
Console.WriteLine("Vetor de Inteiros");
Console.WriteLine(string.Join(", ", integerValues));

Console.WriteLine("********************************");

Console.WriteLine("Vetor de Strings");
string[] stringValues = { "Bolsonaro", "Cleber", "Putin",
"Pica-Pau", "Matuê", "Barack Hussein Obana", "Tais Carla" };

SelectionSort.SelectionSort.Sort(stringValues);
Console.WriteLine(string.Join(", ", stringValues));