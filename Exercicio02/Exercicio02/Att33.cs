using System;

namespace Exercicio02
{
    public class Att33
    {
        public static void Executar()
        {
            Console.Write("Informe a quantidade de alunos: ");
            int quantidade = Classes.ObterNumeroInteiro();

            double soma = 0;
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Informe a matrícula do aluno {i + 1}: ");
                string matricula = Console.ReadLine();

                Console.Write($"Informe a nota do aluno {matricula}: ");
                double nota = Classes.ObterNumeroDecimal();

                soma += nota;
            }

            double media = soma / quantidade;
            Console.WriteLine($"A média das notas dos alunos é {media}.");

            Console.ReadLine();
            Console.Clear();
        }
    }
}
