using System;

namespace Exercicio02
{
    public class Att44
    {
        public static void Executar()
        {
            string resposta;
            do
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Converter de Graus Celsius para Graus Fahrenheit");
                Console.WriteLine("2 - Converter de Graus Fahrenheit para Graus Celsius");
                Console.WriteLine("3 - Calcular o Peso Ideal para Homem");
                Console.WriteLine("4 - Calcular o Peso Ideal para Mulher");
                Console.WriteLine("5 - Vetores e Matrizes (Não Implementado)");
                Console.Write("Opção: ");
                int opcao = Classes.ObterNumeroInteiro();

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite a temperatura em Celsius: ");
                        double temperaturaCelsius = Classes.ObterNumeroDecimal();
                        double temperaturaFahrenheit = temperaturaCelsius * 9 / 5 + 32;
                        Console.WriteLine("Temperatura em Fahrenheit: " + temperaturaFahrenheit);
                        break;
                    case 2:
                        Console.Write("Digite a temperatura em Fahrenheit: ");
                        temperaturaFahrenheit = Classes.ObterNumeroDecimal();
                        temperaturaCelsius = (temperaturaFahrenheit - 32) * 5 / 9;
                        Console.WriteLine("Temperatura em Celsius: " + temperaturaCelsius);
                        break;
                    case 3:
                        Console.Write("Digite a altura em metros: ");
                        double alturaHomem = Classes.ObterNumeroDecimal();
                        double pesoIdealHomem = (72.7 * alturaHomem) - 58;
                        Console.WriteLine("Peso ideal para homem: " + pesoIdealHomem + " kg");
                        break;
                    case 4:
                        Console.Write("Digite a altura em metros: ");
                        double alturaMulher = Classes.ObterNumeroDecimal();
                        double pesoIdealMulher = (62.1 * alturaMulher) - 44.7;
                        Console.WriteLine("Peso ideal para mulher: " + pesoIdealMulher + " kg");
                        break;
                    case 5:
                        Console.WriteLine("Vetores e Matrizes ainda não foram implementados neste programa.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.Write("Deseja encerrar o programa? (S/N): ");
                resposta = Console.ReadLine();
            }
            while (resposta.ToUpper() != "S");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
