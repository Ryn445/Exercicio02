using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
   public class Att10
    {
        public static void Executar()
        {
            //Escrever um programa que leia dois números inteiros e mostre todos os relacionamentos de ordem existentes
            //entre eles. Os relacionamentos possíveis são: Igual, Não igual, Maior, Menor, Maior ou igual, Menor ou igual. 

            Console.WriteLine("informe dois numeros para que seja feito os relaciomentos entre eles");
            Console.WriteLine();
            Console.WriteLine("infome o primeiro Numero Inteiro");
            int N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo numero inteiro");
            int N2 = int.Parse(Console.ReadLine());

            if (N1 == N2)
            {
                Console.WriteLine("O Primeiro e o segundo número são IGUAIS!");

            }
            if (N1 != N2)
            {
                Console.WriteLine("O Primeiro número é DIFERENTE do segundo!");

            }
            if (N1 < N2)
            {
                Console.WriteLine("O primeiro número e MENOR que o segundo");
            }
            if (N1 > N2)
            {

                Console.WriteLine("O primeiro número é MAIOR que o segundo!");

            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
