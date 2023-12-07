using System;

namespace Exercicio02
{
    public class Att47
    {
        public static void Executar()
        {
            int[] vetorNumeros = new int[10];
            int valorX, contMaiores = 0, contMenores = 0, contIguais = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Informe o número na posição " + (i + 1) + ": ");
                vetorNumeros[i] = Classes.ObterNumeroInteiro();
            }

            Console.Write("Informe o valor de X: ");
            valorX = Classes.ObterNumeroInteiro();

            for (int i = 0; i < 10; i++)
            {
                if (vetorNumeros[i] > valorX)
                {
                    contMaiores++;
                }
                else if (vetorNumeros[i] < valorX)
                {
                    contMenores++;
                }
                else
                {
                    contIguais++;
                }
            }

            Console.WriteLine("Quantidade de números maiores que X: " + contMaiores);
            Console.WriteLine("Quantidade de números menores que X: " + contMenores);
            Console.WriteLine("Quantidade de números iguais a X: " + contIguais);

            Console.ReadKey();
            Console.Clear();
        }
    }
}
