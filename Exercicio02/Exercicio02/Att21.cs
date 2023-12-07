using System;

namespace Exercicio02
{
    public class Att21
    {
        public static void Executar()
        {
            Console.WriteLine("Este programa indica se um número é negativo ou positivo.");
            Console.WriteLine();

            Console.Write("Insira um número inteiro: ");
            int numero = Classes.ObterNumeroInteiro();

            if (numero < 0)
            {
                Console.WriteLine($"O número {numero} é negativo.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é positivo.");
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}
