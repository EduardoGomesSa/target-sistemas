public class Program
{
    public static void Main()
    {
        Console.WriteLine("Informe uma palavra: ");
        var palavra = Console.ReadLine().ToArray();

        string palavraInvertida = string.Empty;

        for (int i = palavra.Length - 1; i >= 0; i--)
        {
            palavraInvertida += palavra[i];
        }
        
        Console.WriteLine(palavraInvertida);
    }
}