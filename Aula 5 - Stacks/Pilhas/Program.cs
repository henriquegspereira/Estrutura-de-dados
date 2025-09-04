Console.WriteLine("Ivertendo palavras com pilhas (stacks)");

Console.WriteLine("Digite uma palavra: ");
string palavra = Console.ReadLine();

Stack<char> chars = new Stack<char>();

foreach (var c in palavra)
    chars.Push(c);

string palavra_invertida = String.Empty;

while (chars.Count > 0)   
    palavra_invertida += chars.Pop();

if (palavra_invertida.ToLower() == palavra.ToLower())
{
    Console.WriteLine($"A palavra {palavra} é um palíndromo!");
} else Console.WriteLine($"A palavra não é um palíndromo");