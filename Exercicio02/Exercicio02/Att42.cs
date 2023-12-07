using System;

namespace Exercicio02
{
    public class Att42
    {
        public static void Executar()
        {
            int valor, maior = int.MinValue, menor = int.MaxValue;

            Console.WriteLine("Este programa solicitará valores até que seja digitado ZERO(0) e, em seguida, mostrará o maior e o menor.");
            Console.WriteLine("");
            Console.ReadKey();
            Console.Clear();
            do
            {
                Console.Write("Digite um valor (0 para encerrar): ");
                valor = Classes.ObterNumeroInteiro();

                if (valor != 0)
                {
                    if (valor > maior)
                    {
                        maior = valor;
                    }

                    if (valor < menor)
                    {
                        menor = valor;
                    }
                }
            } while (valor != 0);

            Console.WriteLine("O maior valor inserido foi: " + maior);
            Console.WriteLine("O menor valor inserido foi: " + menor);

            Console.ReadKey();
            Console.Clear();
        }
    }
}
