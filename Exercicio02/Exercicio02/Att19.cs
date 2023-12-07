using System;

namespace Exercicio02
{
    public class Att19
    {
        public static void Executar()
        {
            Console.WriteLine("Este programa determinará o tipo de triângulo com base nos lados.");
            Console.Write("Digite o comprimento do lado A do triângulo: ");
            double comprimentoLadoA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o comprimento do lado B do triângulo: ");
            double comprimentoLadoB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o comprimento do lado C do triângulo: ");
            double comprimentoLadoC = Convert.ToDouble(Console.ReadLine());

            if (comprimentoLadoA < comprimentoLadoB + comprimentoLadoC &&
                comprimentoLadoB < comprimentoLadoA + comprimentoLadoC &&
                comprimentoLadoC < comprimentoLadoA + comprimentoLadoB)
            {
                if (comprimentoLadoA == comprimentoLadoB && comprimentoLadoB == comprimentoLadoC)
                {
                    Console.WriteLine("O triângulo é equilátero.");
                }
                else if (comprimentoLadoA == comprimentoLadoB || comprimentoLadoA == comprimentoLadoC || comprimentoLadoB == comprimentoLadoC)
                {
                    Console.WriteLine("O triângulo é isósceles.");
                }
                else
                {
                    Console.WriteLine("O triângulo é escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Os valores fornecidos não formam um triângulo.");
            }
        }
    }
}
