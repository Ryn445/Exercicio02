using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Att61
    {
        public static void Executar()
        {
            Console.WriteLine("Este programa faz um cálculo de reajuste de salário.");

            Console.Write("Digite o valor do salário: ");
            double salario = Classes.ObterNumeroDecimal();

            Console.Write("Digite o índice de reajuste (em porcentagem): ");
            double indiceReajuste = Classes.ObterNumeroDecimal();

            double salarioAtualizado = Reajuste(salario, indiceReajuste);

            Console.WriteLine($"O salário atualizado é {salarioAtualizado}.");
            Console.ReadLine();
            Console.Clear();
        }

        static double Reajuste(double salario, double indiceReajuste)
        {
            return salario * (1 + indiceReajuste / 100);
        }

    }
}

