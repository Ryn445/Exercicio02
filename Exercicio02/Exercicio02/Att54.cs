using System;
using System.Collections.Generic;

namespace Exercicio02
{
    public class Att54
    {
        public static void Executar()
        {
            Console.WriteLine("Este programa faz a comparação entre os dois grupos e vetores e analisa os comuns entre si");
            Console.WriteLine();

            int[] A = new int[5];
            int[] B = new int[8];

            Console.WriteLine("Digite os elementos do vetor A:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                A[i] = Classes.ObterNumeroInteiro();
            }

            Console.WriteLine("Digite os elementos do vetor B:");
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                B[i] = Classes.ObterNumeroInteiro();
            }

            List<int> comuns = new List<int>();

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[j] && !comuns.Contains(A[i]))
                    {
                        comuns.Add(A[i]);
                    }
                }
            }

            Console.WriteLine("Elementos comuns aos dois vetores:");
            foreach (int num in comuns)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
