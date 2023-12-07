using System;

namespace Exercicio02
{
    public class Att46
    {
        public static void Executar()
        {
            Console.Write("Informe a quantidade de elementos nos vetores: ");
            int quantidade = Classes.ObterNumeroInteiro();

            int[] vetorX = new int[quantidade];
            int[] vetorY = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite o elemento " + (i + 1) + " do vetor X: ");
                vetorX[i] = Classes.ObterNumeroInteiro();
            }

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite o elemento " + (i + 1) + " do vetor Y: ");
                vetorY[i] = Classes.ObterNumeroInteiro();
            }

            int produtoEscalar = 0;
            for (int i = 0; i < quantidade; i++)
            {
                produtoEscalar += vetorX[i] * vetorY[i];
            }

            Console.WriteLine("O produto escalar dos vetores X e Y é: " + produtoEscalar);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
