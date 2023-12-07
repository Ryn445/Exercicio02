using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Classes
    {
        public static int ObterNumeroInteiro()
        {
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }
            return numero;
        }
        public static double ObterNumeroDecimal()
        {
            double numero;
            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }
            return numero;
        }
        public static double ObterNota()
        {
            double nota;
            while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 100)
            {
                Console.WriteLine("Por favor, insira uma nota válida entre 0 e 100.");
            }
            return nota;
        }
        public static void CompararValores(int valor1, int valor2)
        {
            if (valor1 > valor2)
            {
                Console.WriteLine($"O maior valor é {valor1} e o menor valor é {valor2}");
            }
            else if (valor1 < valor2)
            {
                Console.WriteLine($"O maior valor é {valor2} e o menor valor é {valor1}");
            }
            else
            {
                Console.WriteLine("Os dois valores são iguais.");
            }
        }
        public static void ValidarCodigo(int codigo)
        {
            switch (codigo)
            {
                case 1:
                    Console.WriteLine("CÓDIGO 1 - Este é um número válido!");
                    break;
                case 2:
                    Console.WriteLine("CÓDIGO 2 - Este é um número válido!");
                    break;
                case 3:
                    Console.WriteLine("CÓDIGO 3 - Este é um número válido!");
                    break;
                default:
                    Console.WriteLine("CÓDIGO INVÁLIDO");
                    break;
            }
        }
        public static long CalcularFatorial(int numero)
        {
            if (numero < 0)
            {
                Console.WriteLine("Número inválido. O fatorial não é definido para números negativos.");
                return 0;
            }

            long fatorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                fatorial *= i;
            }

            return fatorial;
     
        }
        public static void RealizarOperacao(double numero, string operacao, int i)
        {
            switch (operacao)
            {
                case "1":
                    Console.WriteLine($"{numero} x {i} = {numero * i}");
                    break;
                case "2":
                    if (i != 0)
                    {
                        Console.WriteLine($"{numero} / {i} = {numero / i}");
                    }
                    else
                    {
                        Console.WriteLine($"{numero} / {i} = indefinido");
                    }
                    break;
                case "3":
                    Console.WriteLine($"{numero} - {i} = {numero - i}");
                    break;
                case "4":
                    Console.WriteLine($"{numero} + {i} = {numero + i}");
                    break;
                default:
                    Console.WriteLine("Operação desconhecida.");
                    break;
            }
        }
        public static char ObterCaractereAlfabetico()
        {
            char caractere;
            while (true)
            {
                string input = Console.ReadLine();
                if (input.Length == 1 && char.IsLetter(input[0]))
                {
                    caractere = char.ToUpper(input[0]);
                    break;
                }
                else
                {
                    Console.Write("Erro: digite um caractere alfabético válido (A-Z): ");
                }
            }
            return caractere;
        }
    }
}