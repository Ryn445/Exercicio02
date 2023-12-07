using System;

namespace Exercicio02
{
    public class Att38
    {
        public static void Executar()
        {
            char encerrar;
            do
            {
                Console.WriteLine("Este programa calcula o salário com base nas horas trabalhadas.");
                Console.WriteLine();

                Console.WriteLine("Informe o nome do funcionário:");
                string nomeFuncionario = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Digite o código do colaborador: ");
                string codigoColaborador = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Informe o número de horas trabalhadas: ");
                int horasTrabalhadas = Classes.ObterNumeroInteiro();

                double salario = horasTrabalhadas * 10.0;
                double salarioExcedente = 0.0;

                if (horasTrabalhadas > 50)
                {
                    int horasExcedentes = horasTrabalhadas - 50;
                    salarioExcedente = horasExcedentes * 20.0;
                }

                Console.WriteLine($"O salário total do colaborador {nomeFuncionario} código {codigoColaborador} é R$ {salario}.");
                Console.WriteLine();
                Console.WriteLine($"O salário excedente do colaborador {nomeFuncionario} código {codigoColaborador} é R$ {salarioExcedente}.");

                Console.Write("Deseja encerrar o programa (S/N)? ");
                encerrar = Convert.ToChar(Console.ReadLine());
            } while (encerrar != 'S' && encerrar != 's');
            Console.ReadKey();
            Console.Clear();
        }
    }
}
