using System.Diagnostics.Metrics;

namespace TP2Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countHomem = 0;
            int countMulher = 0;
            int countCrianca = 0;
            int countIdoso = 0;
            int total = 0;

            char entrada;

            Console.WriteLine("Entre com um caractere (H, M, C, I) ou F para encerrar");

            while (true)
            {
                entrada = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (entrada == 'F' || entrada == 'f')
                {
                    break;
                }

                switch (entrada)
                {
                    case 'H':
                    case 'h':
                        countHomem++;
                        break;
                    case 'M':
                    case 'm':
                        countMulher++;
                        break;
                    case 'C':
                    case 'c':
                        countCrianca++;
                        break;
                    case 'I':
                    case 'i':
                        countIdoso++;
                        break;
                    default:
                        Console.WriteLine("Caractere inválido, tente novamente.");
                        continue;
                }

                total++;

            }
            if (total > 0)
            {
                double percHomem = (double)countHomem / total * 100;
                double percMulher = (double)countMulher / total * 100;
                double percCrianca = (double)countCrianca / total * 100;
                double percIdoso = (double)countIdoso / total * 100;

                Console.WriteLine($"Total de homens = {countHomem} - {percHomem:F2}%");
                Console.WriteLine($"Total de mulheres = {countMulher} - {percMulher:F2}%");
                Console.WriteLine($"Total de crianças = {countCrianca} - {percCrianca:F2}%");
                Console.WriteLine($"Total de idosos = {countIdoso} - {percIdoso:F2}%");
            }
            else
            {
                Console.WriteLine("Nenhum caractere válido foi inserido.");

            }
        }

    }
}
