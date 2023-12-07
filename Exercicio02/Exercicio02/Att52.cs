using System;


namespace Exercicio02
{
    public class Att52
    {
        public static void Executar()
        {
            int[] vetor = new int[100];
            int contador1 = 0, contador3 = 0, contador4 = 0;
            int numero;

            Console.WriteLine("Digite os números do vetor (digite -1 para sair):");

            for (int i = 0; i < 100; i++)
            {
                numero = Classes.ObterNumeroInteiro();

                if (numero == -1)
                {
                    break;
                }

                vetor[i] = numero;

                if (numero == 1)
                {
                    contador1++;
                }
                else if (numero == 3)
                {
                    contador3++;
                }
                else if (numero == 4)
                {
                    contador4++;
                }
            }

            Console.WriteLine($"O número 1 aparece {contador1} vezes.");
            Console.WriteLine($"O número 3 aparece {contador3} vezes.");
            Console.WriteLine($"O número 4 aparece {contador4} vezes.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
