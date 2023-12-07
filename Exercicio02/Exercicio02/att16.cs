using System;

namespace Exercicio02
{
    public class Att16
    {
        public static void Executar()
        {
            Console.WriteLine("Comparação de Números");
            Console.WriteLine();

            Console.WriteLine("Digite o primeiro valor: ");
            int valor1 = Classes.ObterNumeroInteiro();
            Console.WriteLine();

            Console.WriteLine("Digite o segundo valor: ");
            int valor2 = Classes.ObterNumeroInteiro();
            Console.WriteLine();

            Classes.CompararValores(valor1, valor2);

            Console.ReadLine();
            Console.Clear();
        }

      
    }
}
