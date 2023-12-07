using System;

namespace Exercicio02
{
    public class Att39
    {
        public static void Executar()
        {
            string encerrar;

            do
            {
                Console.WriteLine("Este programa irá analisar se o número inteiro é positivo, negativo, par ou ímpar.");
                Console.WriteLine();

                Console.Write("Insira um número inteiro: ");
                int numeroInteiro = Classes.ObterNumeroInteiro();

                if (numeroInteiro % 2 == 0)
                {
                    Console.WriteLine("O número informado é par.");
                }
                else
                {
                    Console.WriteLine("O número informado é ímpar.");
                }

                if (numeroInteiro >= 0)
                {
                    Console.WriteLine("O número informado é positivo.");
                }
                else
                {
                    Console.WriteLine("O número informado é negativo.");
                }

                Console.Write("Deseja encerrar o programa? (S/N): ");
                encerrar = Console.ReadLine();
            } while (encerrar.ToUpper() != "S");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
