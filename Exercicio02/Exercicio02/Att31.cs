using System;

namespace Exercicio02
{
    public class Att31
    {
        public static void Executar()
        {
            Console.WriteLine("Informe números pares e ímpares, o programa dará a soma dos pares e dos ímpares.");
            Console.WriteLine("Para encerrar, basta digitar um número negativo.");
            Console.WriteLine();

            int sumEvenNumbers = 0;
            int sumOddNumbers = 0;
            int number;

            Console.WriteLine("Digite um número positivo (ou um número negativo para encerrar):");
            number = Classes.ObterNumeroInteiro();

            while (number >= 0)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} é par.");
                    sumEvenNumbers += number;
                }
                else
                {
                    Console.WriteLine($"{number} é ímpar.");
                    sumOddNumbers += number;
                }

                Console.WriteLine("Digite outro número positivo (ou um número negativo para encerrar):");
                number = Classes.ObterNumeroInteiro();
            }

            Console.WriteLine($"A soma dos números pares é {sumEvenNumbers}.");
            Console.WriteLine($"A soma dos números ímpares é {sumOddNumbers}.");

            Console.ReadLine();
            Console.Clear();
        }
    }
}


