using System;

namespace Exercicio02
{
    public class Att20
    {
        public static void Executar()
        {
            Console.WriteLine("Este programa exibe o resultado da multiplicação do menor valor pelo maior e a divisão do maior valor pelo menor.");

            int numeroA, numeroB, numeroC;

            Console.Write("Digite um valor inteiro maior que zero para A: ");
            numeroA = Classes.ObterNumeroInteiro();

            Console.Write("Digite um valor inteiro maior que zero para B: ");
            numeroB = Classes.ObterNumeroInteiro();

            Console.Write("Digite um valor inteiro maior que zero para C: ");
            numeroC = Classes.ObterNumeroInteiro();

            int menorValor = Math.Min(numeroA, Math.Min(numeroB, numeroC));
            int maiorValor = Math.Max(numeroA, Math.Max(numeroB, numeroC));

            Console.WriteLine($"O menor valor multiplicado pelo maior é {menorValor * maiorValor}");
            Console.WriteLine($"O maior valor dividido pelo menor é {(double)maiorValor / menorValor}");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

