using System;

namespace Exercicio02
{
    public class Att40
    {
        public static void Executar()
        {
            string encerrar;

            do
            {
                Console.WriteLine("Este programa irá analisar o índice de poluição e fornecerá informações sobre a situação.");
                Console.WriteLine();

                Console.Write("Insira o índice de poluição atmosférica (entre 0.0 e 1.0): ");
                double indicePoluicao = Classes.ObterNumeroDecimal();

                if (indicePoluicao >= 0.05 && indicePoluicao <= 0.25)
                {
                    Console.WriteLine("O índice de poluição está dentro dos limites aceitáveis.");
                }
                else if (indicePoluicao >= 0.3 && indicePoluicao < 0.4)
                {
                    Console.WriteLine("As indústrias do 1º grupo devem suspender suas atividades temporariamente.");
                }
                else if (indicePoluicao >= 0.4 && indicePoluicao < 0.5)
                {
                    Console.WriteLine("As indústrias dos 1º e 2º grupos devem suspender suas atividades temporariamente.");
                }
                else if (indicePoluicao >= 0.5)
                {
                    Console.WriteLine("Todas as indústrias devem paralisar suas atividades imediatamente.");
                }

                Console.Write("Deseja encerrar o programa? (S/N): ");
                encerrar = Console.ReadLine();
            } while (encerrar.ToUpper() != "S");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
