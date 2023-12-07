using System;

namespace Exercicio02
{
    public class Att32
    {
        public static void Executar()
        {
            Console.WriteLine("Este programa calculará a soma dos quadrados dos próximos números ímpares entre 0 e 10.");
            Console.WriteLine();

            Console.Write("Insira um número ímpar menor que 10 e maior que zero: ");
            int numero = Classes.ObterNumeroInteiro();

            if (numero <= 0 || numero >= 10 || numero % 2 == 0)
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número ímpar menor que 10 e maior que zero.");
                return;
            }

            int soma = 0;
            for (int i = numero; i < numero + 40; i += 2)
            {
                soma += i * i;
            }

            Console.WriteLine($"A soma dos quadrados dos 20 próximos números ímpares, a partir de {numero}, é: {soma}.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
