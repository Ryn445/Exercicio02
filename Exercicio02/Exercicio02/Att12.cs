using System;

namespace Exercicio02
{
    public class Att12
    {
        public static void Executar()
        {
            Console.WriteLine("Encontrar o módulo de um número");
            Console.Write("Digite um número inteiro: ");

            int numero = Classes.ObterNumeroInteiro();

            int modulo = numero >= 0 ? numero : numero * -1;

            Console.WriteLine($"O módulo do número é: {modulo}");

            Console.ReadKey();
        }
    }
}
