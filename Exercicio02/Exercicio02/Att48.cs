using System;

namespace Exercicio02
{
    public class Att48
    {
        public static void Executar()
        {
            // Declare arrays to store names and ages
            string[] arrayNomes = new string[20];
            int[] arrayIdades = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Informe o nome da candidata " + (i + 1) + ": ");
                arrayNomes[i] = Console.ReadLine();
                Console.Write("Informe a idade da candidata " + (i + 1) + ": ");
                arrayIdades[i] = Classes.ObterNumeroInteiro();
            }

            Console.WriteLine("Candidatas aptas a concorrer a uma vaga para a campanha milionária:");
            for (int i = 0; i < 20; i++)
            {
                if (arrayIdades[i] >= 18 && arrayIdades[i] <= 20)
                {
                    Console.WriteLine(arrayNomes[i]);
                }
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}
