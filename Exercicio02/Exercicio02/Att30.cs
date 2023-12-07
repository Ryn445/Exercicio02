using System;

namespace Exercicio02
{
    public class Att30
    {
        public static void Executar()
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("");
            Console.WriteLine("Informe um número e escolha a operação desejada!");
            Console.WriteLine("");

            double numero = Classes.ObterNumeroDecimal();

            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1 - Multiplicar");
            Console.WriteLine("2 - Dividir");
            Console.WriteLine("3 - Subtrair");
            Console.WriteLine("4 - Somar");

            string operacao = Console.ReadLine();

            for (int i = 0; i <= 10; i++)
            {
                Classes.RealizarOperacao(numero, operacao, i);
            }

            Console.ReadLine();
            Console.Clear();
        }

        
    }
}
