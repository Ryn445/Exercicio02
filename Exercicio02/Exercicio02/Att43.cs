using System;

namespace Exercicio02
{
    public class Att43
    {
        public static void Executar()
        {
            double totalGrãos = 0;

            for (int i = 0; i < 64; i++)
            {
                double grãosNoQuadro = Math.Pow(2, i);
                totalGrãos += grãosNoQuadro;
                Console.WriteLine("Quadro " + (i + 1) + ": " + grãosNoQuadro + " grãos");
            }

            Console.WriteLine("O total de grãos que o monge esperava receber é: " + totalGrãos);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
