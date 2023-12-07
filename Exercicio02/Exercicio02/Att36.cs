using System;

namespace Exercicio02
{
    public class Att36
    {
        public static void Executar()
        {
            Console.WriteLine("Este programa analisará 10 números que você fornecerá. Ele identificará o maior, o menor e calculará a média entre eles.");
            Console.WriteLine();
            Console.WriteLine("Digite os números conforme solicitado:");

            int maiorNumero = int.MinValue;
            int menorNumero = int.MaxValue;
            int somaNumeros = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um número inteiro e positivo: ");
                int numero = Classes.ObterNumeroInteiro();

                if (numero > maiorNumero)
                {
                    maiorNumero = numero;
                }

                if (numero < menorNumero)
                {
                    menorNumero = numero;
                }

                somaNumeros += numero;
            }

            double mediaNumeros = somaNumeros / 10.0;

            Console.WriteLine("O maior número digitado é: " + maiorNumero);
            Console.WriteLine("O menor número digitado é: " + menorNumero);
            Console.WriteLine("A média dos números é: " + mediaNumeros);
            Console.ReadLine();
            Console.Clear();
        }
    }
}

