using System;

namespace Exercicio02
{
    public class Att53
    {
        public static void Executar()
        {
            Console.Write("Digite o número de voltas: ");
            int Numero = Classes.ObterNumeroInteiro();

            double[] tempos = new double[Numero];
            double somaTempos = 0, melhorTempo = double.MaxValue;
            int voltaMelhorTempo = 0;

            for (int i = 0; i < Numero; i++)
            {
                Console.Write($"Digite o tempo da volta {i + 1}: ");
                tempos[i] = Classes.ObterNumeroDecimal();
                somaTempos += tempos[i];

                if (tempos[i] < melhorTempo)
                {
                    melhorTempo = tempos[i];
                    voltaMelhorTempo = i + 1;
                }
            }

            double tempoMedio = somaTempos / Numero;

            Console.WriteLine($"Melhor tempo: {melhorTempo}");
            Console.WriteLine($"Volta do melhor tempo: {voltaMelhorTempo}");
            Console.WriteLine($"Tempo médio: {tempoMedio}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

