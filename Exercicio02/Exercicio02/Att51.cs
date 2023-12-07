using System;

namespace Exercicio02
{
    public class Att51
    {
        public static void Executar()
        {
            Console.WriteLine("Este programa irá mostrar as notas dos alunos e calcular a média.");

            Console.Write("Digite a quantidade de alunos: ");
            int quantidade = Classes.ObterNumeroInteiro();

          

            double soma = 0;
            int acimaDeSete = 0;
            bool acimaDeCinco = false;

            for (int i = 1; i <= quantidade; i++)
            {
                Console.Write($"Digite a nota do aluno {i}: ");
                double nota = Classes.ObterNumeroDecimal();

                soma += nota;

                if (nota > 7)
                {
                    acimaDeSete++;
                }

                if (nota > 5)
                {
                    acimaDeCinco = true;
                }
            }

            double media = soma / quantidade;

            Console.WriteLine($"A média aritmética das notas é {media}.");
            Console.WriteLine($"Há {acimaDeSete} alunos com nota acima de 7.0.");

            if (!acimaDeCinco)
            {
                Console.WriteLine("Não há nenhum aluno com nota acima de 5.");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }

}