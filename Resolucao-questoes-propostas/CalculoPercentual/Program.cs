public class Program
{
    public static void Main()
    {
        double SP = 67836.43, RJ = 36678.66, MG = 29229.88, ES = 27165.48, Outros = 19849.53, soma = 0;
        double porcentagemSP = 0, porcentagemRJ = 0, porcentagemMG = 0, porcentagemES = 0, porcentagemOutros = 0;

        soma = SP + RJ + MG + ES + Outros;

        porcentagemSP = (SP * 100) / soma;
        porcentagemRJ = (RJ * 100) / soma;
        porcentagemMG = (MG * 100) / soma;
        porcentagemES = (ES * 100) / soma;
        porcentagemOutros = (Outros * 100) / soma;

        Console.WriteLine("Total do faturamento: " + soma);
        Console.WriteLine("Porcentagem SP: " + porcentagemSP.ToString("N2"));
        Console.WriteLine("Porcentagem RJ: " + porcentagemRJ.ToString("N2"));
        Console.WriteLine("Porcentagem MG: " + porcentagemMG.ToString("N2"));
        Console.WriteLine("Porcentagem ES: " + porcentagemES.ToString("N2"));
        Console.WriteLine("Porcentagem Outros: " + porcentagemOutros.ToString("N2"));
    }
}