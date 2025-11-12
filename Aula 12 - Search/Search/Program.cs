public class Program {

    public static void Main()
    {
        string[] storage = { "artur", "1", "carlos", "daniel", "e", "fernando", "7", "8", "indio", "jaca" };

        bool encontrado = false;

        Console.WriteLine("Qual elemento você deseja buscar: ");

        string? numeroProcurado = Console.ReadLine();

        for (int i = 0; i < storage.Length; i++)
        {
            if (storage[i] == numeroProcurado)
            {
                Console.WriteLine("Elemento encontrado na posição: " + i);
                encontrado = true;
                break;
            }
        }   

        if (!encontrado)
        {
            Console.WriteLine("Elemento não encontrado");
        }
    }
}