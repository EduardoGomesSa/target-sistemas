public class Program
{
    public static void Main()
    {
        int numero1 = 0, numero2 = 1, soma = 0, numeroDigitado = 0;
        bool PertenceSequencia = false;

        Console.WriteLine("Informe um número");
        numeroDigitado = Int32.Parse(Console.ReadLine());

        for (int i = 0; i <= numeroDigitado; i++)
        {
            soma = numero1 + numero2;
            numero1 = numero2;
            numero2 = soma;

            if(soma == numeroDigitado || numeroDigitado == 0)
            {
                PertenceSequencia = true;
            }
        }
        if (PertenceSequencia)
        {
            Console.WriteLine($"O número {numeroDigitado} está presente na sequência de Fibonacci");
        }
        else
        {
            Console.WriteLine($"O número {numeroDigitado} não está presente na sequência de Fibonacci");
        }
        
    }
}