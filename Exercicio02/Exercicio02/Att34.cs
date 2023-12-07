using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Att34
    {
        public static void Executar()
        {
            double numero;
            double maior = double.MinValue; 
            double menor = double.MaxValue; 

            Console.WriteLine("Digite um número positivo (ou um número negativo para terminar):");
            numero = Classes.ObterNumeroDecimal();

            while (numero >= 0)
            {
                if (numero > maior)
                {
                    maior = numero;
                }

                if (numero < menor)
                {
                    menor = numero;
                }

                Console.WriteLine("Digite outro número positivo (ou um número negativo para terminar):");
                numero = Classes.ObterNumeroDecimal();
            }

            Console.WriteLine($"O maior número digitado foi {maior}.");
            Console.WriteLine($"O menor número digitado foi {menor}.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
