using System;

namespace Exercicio02
{
    public class Att08
    {
        public static void Executar()
        {
            Console.WriteLine("Cálculo do volume de uma lata de óleo");
            Console.WriteLine();
            Console.WriteLine("Informe a Altura da lata de óleo:");
            double alturaLata = Classes.ObterNumeroDecimal();
            Console.WriteLine("Informe o Raio da lata de óleo:");
            double raioLata = Classes.ObterNumeroDecimal();

            double volumeLata = 3.14159 * raioLata * raioLata * alturaLata;

            Console.WriteLine($"O volume em litros desta lata de óleo é de: {volumeLata} litros");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
