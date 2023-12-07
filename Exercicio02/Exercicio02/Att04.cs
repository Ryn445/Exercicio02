using System;

namespace Exercicio02
{
    public class Att04
    {
        public static void Executar()
        {
            Console.WriteLine("Informe quatro números para serem somados e multiplicados entre si!");
            Console.WriteLine();
            Console.WriteLine("Informe o PRIMEIRO valor:");
            double valorA = Classes.ObterNumeroDecimal();
            Console.WriteLine("Informe o SEGUNDO valor:");
            double valorB = Classes.ObterNumeroDecimal();
            Console.WriteLine("Informe o TERCEIRO valor:");
            double valorC = Classes.ObterNumeroDecimal();
            Console.WriteLine("Informe o QUARTO valor:");
            double valorD = Classes.ObterNumeroDecimal();
            Console.WriteLine();

            // Adições
            double somaAB = valorA + valorB;
            double somaAC = valorA + valorC;
            double somaAD = valorA + valorD;
            double somaBC = valorB + valorC;
            double somaBD = valorB + valorD;
            double somaCD = valorC + valorD;

            // Multiplicações
            double multAB = valorA * valorB;
            double multAC = valorA * valorC;
            double multAD = valorA * valorD;
            double multBC = valorB * valorC;
            double multBD = valorB * valorD;
            double multCD = valorC * valorD;

            // Mostrar as somas
            Console.WriteLine("********* Resultados das SOMAS *********************");
            Console.WriteLine();

            Console.WriteLine($"O resultado da soma do PRIMEIRO com o SEGUNDO é: {somaAB}");
            Console.WriteLine($"O resultado da soma do PRIMEIRO com o TERCEIRO é: {somaAC}");
            Console.WriteLine($"O resultado da soma do PRIMEIRO com o QUARTO é: {somaAD}");
            Console.WriteLine($"O resultado da soma do SEGUNDO com o TERCEIRO é: {somaBC}");
            Console.WriteLine($"O resultado da soma do SEGUNDO com o QUARTO é: {somaBD}");
            Console.WriteLine($"O resultado da soma do TERCEIRO com o QUARTO é: {somaCD}");
            Console.WriteLine();

            // Mostrar as multiplicações
            Console.WriteLine("********* Resultados das MULTIPLICAÇÕES *************");
            Console.WriteLine();

            Console.WriteLine($"O resultado da multiplicação do PRIMEIRO com o SEGUNDO é: {multAB}");
            Console.WriteLine($"O resultado da multiplicação do PRIMEIRO com o TERCEIRO é: {multAC}");
            Console.WriteLine($"O resultado da multiplicação do PRIMEIRO com o QUARTO é: {multAD}");
            Console.WriteLine($"O resultado da multiplicação do SEGUNDO com o TERCEIRO é: {multBC}");
            Console.WriteLine($"O resultado da multiplicação do SEGUNDO com o QUARTO é: {multBD}");
            Console.WriteLine($"O resultado da multiplicação do TERCEIRO com o QUARTO é: {multCD}");
            Console.WriteLine();

            Console.ReadKey();
            Console.Clear();
        }
    }
}
