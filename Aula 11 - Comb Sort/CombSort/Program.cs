using System;

class Program
{
    static void Main()
    {
        int[] vetor = { 8, 4, 1, 56, 3, -44, 23, -6, 28, 0 };
        
        Console.WriteLine("Vetor original:");
        ImprimirVetor(vetor);

        CombSort.CombSort.Sort(vetor);

        Console.WriteLine("\nVetor ordenado:");
        ImprimirVetor(vetor);
    }
    static void ImprimirVetor(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}