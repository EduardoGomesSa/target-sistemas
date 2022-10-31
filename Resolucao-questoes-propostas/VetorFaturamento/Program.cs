using Newtonsoft.Json;
using VetorFaturamento;

public class Program
{
    public static void Main()
    {
        string jsonFaturamentoMes = "\r\n[\r\n\t{\r\n\t\t\"dia\": 1,\r\n\t\t\"valor\": 22174.1664\r\n\t},\r\n\t{\r\n\t\t\"dia\": 2,\r\n\t\t\"valor\": 24537.6698\r\n\t},\r\n\t{\r\n\t\t\"dia\": 3,\r\n\t\t\"valor\": 26139.6134\r\n\t},\r\n\t{\r\n\t\t\"dia\": 4,\r\n\t\t\"valor\": 0.0\r\n\t},\r\n\t{\r\n\t\t\"dia\": 5,\r\n\t\t\"valor\": 0.0\r\n\t},\r\n\t{\r\n\t\t\"dia\": 6,\r\n\t\t\"valor\": 26742.6612\r\n\t},\r\n\t{\r\n\t\t\"dia\": 7,\r\n\t\t\"valor\": 0.0\r\n\t},\r\n\t{\r\n\t\t\"dia\": 8,\r\n\t\t\"valor\": 42889.2258\r\n\t},\r\n\t{\r\n\t\t\"dia\": 9,\r\n\t\t\"valor\": 46251.174\r\n\t},\r\n\t{\r\n\t\t\"dia\": 10,\r\n\t\t\"valor\": 11191.4722\r\n\t},\r\n\t{\r\n\t\t\"dia\": 11,\r\n\t\t\"valor\": 0.0\r\n\t},\r\n\t{\r\n\t\t\"dia\": 12,\r\n\t\t\"valor\": 0.0\r\n\t},\r\n\t{\r\n\t\t\"dia\": 13,\r\n\t\t\"valor\": 3847.4823\r\n\t},\r\n\t{\r\n\t\t\"dia\": 14,\r\n\t\t\"valor\": 373.7838\r\n\t},\r\n\t{\r\n\t\t\"dia\": 15,\r\n\t\t\"valor\": 2659.7563\r\n\t},\r\n\t{\r\n\t\t\"dia\": 16,\r\n\t\t\"valor\": 48924.2448\r\n\t},\r\n\t{\r\n\t\t\"dia\": 17,\r\n\t\t\"valor\": 18419.2614\r\n\t},\r\n\t{\r\n\t\t\"dia\": 18,\r\n\t\t\"valor\": 0.0\r\n\t},\r\n\t{\r\n\t\t\"dia\": 19,\r\n\t\t\"valor\": 0.0\r\n\t},\r\n\t{\r\n\t\t\"dia\": 20,\r\n\t\t\"valor\": 35240.1826\r\n\t},\r\n\t{\r\n\t\t\"dia\": 21,\r\n\t\t\"valor\": 43829.1667\r\n\t},\r\n\t{\r\n\t\t\"dia\": 22,\r\n\t\t\"valor\": 18235.6852\r\n\t},\r\n\t{\r\n\t\t\"dia\": 23,\r\n\t\t\"valor\": 4355.0662\r\n\t},\r\n\t{\r\n\t\t\"dia\": 24,\r\n\t\t\"valor\": 13327.1025\r\n\t},\r\n\t{\r\n\t\t\"dia\": 25,\r\n\t\t\"valor\": 0.0\r\n\t},\r\n\t{\r\n\t\t\"dia\": 26,\r\n\t\t\"valor\": 0.0\r\n\t},\r\n\t{\r\n\t\t\"dia\": 27,\r\n\t\t\"valor\": 25681.8318\r\n\t},\r\n\t{\r\n\t\t\"dia\": 28,\r\n\t\t\"valor\": 1718.1221\r\n\t},\r\n\t{\r\n\t\t\"dia\": 29,\r\n\t\t\"valor\": 13220.495\r\n\t},\r\n\t{\r\n\t\t\"dia\": 30,\r\n\t\t\"valor\": 8414.61\r\n\t}\r\n]";
        decimal menorValor = 100000, maiorValor = 0, somaParaMedia = 0, media = 0;
        int quantidadeDiasSuperiorAMedia = 0, diasValidos = 0, menorDiaFaturamento = 0, maiorDiaFaturamento = 0;

        List<Mes> listaMes = new List<Mes>();
        listaMes = JsonConvert.DeserializeObject<List<Mes>>(jsonFaturamentoMes);

        for (int i = 0; i < listaMes.Count; i++)
        {
            if (listaMes[i].Valor > maiorValor)
            {
                maiorValor = listaMes[i].Valor;
                maiorDiaFaturamento = listaMes[i].Dia;
            }

            if(listaMes[i].Valor < menorValor && listaMes[i].Valor != 0)
            {
                menorValor = listaMes[i].Valor;
                menorDiaFaturamento = listaMes[i].Dia;
            }

            if(listaMes[i].Valor != 0)
            {
                somaParaMedia += listaMes[i].Valor;
                diasValidos += 1;
            }
        }

        media = somaParaMedia / diasValidos;

        for (int i = 0; i < listaMes.Count; i++)
        {
            if (listaMes[i].Valor > media)
            {
                quantidadeDiasSuperiorAMedia += 1;
            }
        }

        Console.WriteLine("Menor valor do mês foi: " + menorValor + " no dia: "+ menorDiaFaturamento);
        Console.WriteLine("O maior valor do mês foi: " + maiorValor + " no dia: " + maiorDiaFaturamento);
        Console.WriteLine("Quantidade de dias com valor maior que a média é: " + quantidadeDiasSuperiorAMedia);
    }
}