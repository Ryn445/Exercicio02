using System;
using System.Collections.Generic;

namespace Exercicio02
{
    public class Att56
    {
        public static void Executar()
        {
            Console.WriteLine("Este programa e capaz de analizar números de um vetor e anlizar os multiplos de 5 e d a quantidade de números pares");

            int[] vetor = new int[50];
            int contPares = 0, contMultiplos5 = 0;

            Console.WriteLine("Digite os elementos do vetor:");

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Elemento {i + 1}: ");
                vetor[i] = Classes.ObterNumeroInteiro();

                if (vetor[i] % 2 == 0)
                {
                    contPares++;
                }

                if (vetor[i] % 5 == 0)
                {
                    contMultiplos5++;
                }
            }

            Console.WriteLine($"Quantidade de números pares: {contPares}");
            Console.WriteLine($"Quantidade de múltiplos de 5: {contMultiplos5}");
        }

      
    }
}
