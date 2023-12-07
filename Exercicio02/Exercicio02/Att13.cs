using System.Collections.Generic;
using System.Linq;
using System;

namespace Exercicio02
{
    public class Att13
    {
        public static void Executar()
        {
            Console.WriteLine("Ordenação Decrescente de Três Números");
            Console.WriteLine();

            Console.Write("Digite o primeiro número inteiro: ");
            int primeiroNumero = Classes.ObterNumeroInteiro();

            Console.Write("Digite o segundo número inteiro: ");
            int segundoNumero = Classes.ObterNumeroInteiro();

            Console.Write("Digite o terceiro número inteiro: ");
            int terceiroNumero = Classes.ObterNumeroInteiro();

            int[] numeros = new int[] { primeiroNumero, segundoNumero, terceiroNumero };

            Array.Sort(numeros);
            Array.Reverse(numeros);

            Console.WriteLine($"Em ordem decrescente fica: {numeros[0]}, {numeros[1]}, {numeros[2]}");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
