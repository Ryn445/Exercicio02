using System;

namespace Exercicio02
{
    public class Att60
    {
        public static void Executar()
        {
            Console.Write("Digite o valor para x: ");
            double x = Classes.ObterNumeroDecimal();

            Console.Write("Digite o valor para y: ");
            double y = Classes.ObterNumeroDecimal();

            int quadrante = VerificaQuadrante(x, y);

            Console.WriteLine($"O ponto ({x}, {y}) está no quadrante {quadrante}.");

            Console.ReadKey();
            Console.Clear();
        }

        static int VerificaQuadrante(double x, double y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x < 0 && y > 0)
            {
                return 2;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
    }
}
