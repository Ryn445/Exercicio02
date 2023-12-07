using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Att35
    {
        public static void Executar()
        {
            Console.WriteLine("Este programa irá escrever os números de 1 a 100 e informar os múltiplos de 10.");
            Console.WriteLine();

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
                if (i % 10 == 0)
                {
                    Console.WriteLine($"O número acima ({i}) é múltiplo de 10.");
                }
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}
