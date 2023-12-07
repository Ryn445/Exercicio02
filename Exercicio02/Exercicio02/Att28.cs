using System;

namespace Exercicio02
{
    public class Att28
    {
        public static void Executar()
        {
            Console.WriteLine("Este programa exibirá os números ímpares entre 100 e 200");
            Console.WriteLine();

            for (int i = 100; i <= 200; i++)
            {
                if (EhImpar(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
            Console.Clear();
        }

        static bool EhImpar(int numero)
        {
            return numero % 2 != 0;
        }
    }
}
