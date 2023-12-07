using System;

namespace Exercicio02
{
    public class Att22
    {
        public static void Executar()
        {
            Console.WriteLine("Informe um número e o console indicará se foi armazenado em ValorA ou ValorB");
            Console.WriteLine();

            Console.Write("Digite um número inteiro: ");
            int numero = Classes.ObterNumeroInteiro();

            int? ValorA = null;
            int? ValorB = null;

            if (numero >= 0)
            {
                ValorA = numero;
                Console.WriteLine($"O número {numero} foi armazenado em ValorA.");
            }
            else
            {
                ValorB = numero;
                Console.WriteLine($"O número {numero} foi armazenado em ValorB.");
            }

            if (ValorA.HasValue)
                Console.WriteLine($"ValorA = {ValorA.Value}");
            else
                Console.WriteLine("ValorA não foi definido.");

            if (ValorB.HasValue)
                Console.WriteLine($"ValorB = {ValorB.Value}");
            else
                Console.WriteLine("ValorB não foi definido.");

            Console.ReadLine();
            Console.Clear();
        }
    }
}

