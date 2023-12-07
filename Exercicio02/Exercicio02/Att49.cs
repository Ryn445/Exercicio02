using System;

namespace Exercicio02
{
    public class Att49
    {
        public static void Executar()
        {
            Console.Write("Informe o número de componentes nos vetores: ");
            int quantidadeComponentes = Classes.ObterNumeroInteiro();

            if (quantidadeComponentes > 50)
            {
                Console.WriteLine("A quantidade de componentes não pode ser maior que 50.");
                return;
            }

            int[] vetor1 = new int[quantidadeComponentes];
            int[] vetor2 = new int[quantidadeComponentes];

            for (int i = 0; i < quantidadeComponentes; i++)
            {
                Console.Write("Informe o componente " + (i + 1) + " do vetor V1: ");
                vetor1[i] = Classes.ObterNumeroInteiro();
            }

            for (int i = 0; i < quantidadeComponentes; i++)
            {
                Console.Write("Informe o componente " + (i + 1) + " do vetor V2: ");
                vetor2[i] = Classes.ObterNumeroInteiro();
            }

            int contagem = 0;
            for (int i = 0; i < quantidadeComponentes; i++)
            {
                if (vetor1[i] == vetor2[i])
                {
                    contagem++;
                }
            }

            Console.WriteLine("Vetor 1 e Vetor 2 possuem valores idênticos nas mesmas posições " + contagem + " vezes.");

            Console.ReadKey();
            Console.Clear();
        }
    }
}

