using System;

namespace Exercicio02
{
    public class Att27
    {
        public static void Executar()
        {
            Console.Write("Digite a quantidade de números para os quais você deseja calcular o fatorial: ");
            int quantidade = Classes.ObterNumeroInteiro();

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite um número: ");
                int numero = Classes.ObterNumeroInteiro();

                long fatorial = Classes.CalcularFatorial(numero);

                Console.WriteLine($"O fatorial de {numero} é {fatorial}");
            }
        }
    }

}

