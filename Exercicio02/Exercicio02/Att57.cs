using System;

namespace Exercicio02
{
    public class Att57
    {
        public static void Executar()
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            Console.Write("Vogais na frase: ");

            foreach (char c in frase)
            {
                if (EhVogal(c))
                {
                    Console.Write(c);
                }
            }

            Console.WriteLine();

            Console.ReadKey();
            Console.Clear();
        }

        private static bool EhVogal(char caractere)
        {
            string vogais = "aeiouAEIOU";
            return vogais.IndexOf(caractere) >= 0;
        }
    }
}

