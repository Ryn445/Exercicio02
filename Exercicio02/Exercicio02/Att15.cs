using System;

namespace Exercicio02
{
    public class Att15
    {
        public static void Executar()
        {
            Console.WriteLine("Programa de Avaliação do Aluno");
            Console.WriteLine();
            Console.Write("Digite o nome do Aluno: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe as notas (0 a 100) do aluno:");
            Console.WriteLine();

            Console.Write("Digite a primeira nota: ");
            double nota1 = Classes.ObterNota();

            Console.Write("Digite a segunda nota: ");
            double nota2 = Classes.ObterNota();

            Console.Write("Digite a terceira nota: ");
            double nota3 = Classes.ObterNota();

            Console.Write("Digite a quarta nota: ");
            double nota4 = Classes.ObterNota();

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 70)
            {
                Console.WriteLine($"O aluno {nome} foi aprovado com uma média de {media}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("O aluno está em recuperação");
                Console.WriteLine();
                Console.Write("Digite a nota da recuperação: ");
                double notaRecuperacao = Classes.ObterNota();
                Console.WriteLine();

                media = (media + notaRecuperacao) / 2;

                if (media >= 70)
                {
                    Console.WriteLine($"O aluno {nome} foi aprovado com uma média de {media}");
                }
                else
                {
                    Console.WriteLine($"O aluno {nome} está REPROVADO com uma média de {media}");
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
