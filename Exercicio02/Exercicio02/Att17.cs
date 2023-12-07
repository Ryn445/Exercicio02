using System;

namespace Exercicio02
{
    public class Att17
    {
        public static void Executar()
        {
            Console.WriteLine("Este programa será capaz de identificar se um número é válido ou inválido");
            Console.WriteLine();
            Console.Write("Digite um número inteiro: ");
            int numero = Classes.ObterNumeroInteiro();

            if (numero >= 0 && numero <= 9)
            {
                Console.WriteLine("Número válido");
            }
            else
            {
                Console.WriteLine("Número inválido");
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}
