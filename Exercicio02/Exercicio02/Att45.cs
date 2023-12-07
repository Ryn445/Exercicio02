using System;

namespace Exercicio02
{
    public class Att45
    {
        public static void Executar()
        {
            Console.WriteLine("Este programa mostrará os números digitados em ordem inversa.");
            Console.WriteLine();

            Console.Write("Digite a quantidade de elementos na sequência: ");
            int quantidade = Classes.ObterNumeroInteiro();

            int[] numeros = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite o número na posição " + (i + 1) + ": ");
                numeros[i] = Classes.ObterNumeroInteiro();
            }

            Console.WriteLine("Sequência na ordem inversa:");
            for (int i = quantidade - 1; i >= 0; i--)
            {
                Console.WriteLine("Número na posição " + (i + 1) + ": " + numeros[i]);
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
