using System;

namespace Exercicio02
{
    public class Att37
    {
        public static void Executar()
        {
            char escolha;
            do
            {
                Console.WriteLine("Este programa realiza cálculos matemáticos simples.");
                Console.WriteLine();
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.Write("Informe a opção desejada: ");
                int opcao = Classes.ObterNumeroInteiro();

                Console.Write("Digite o primeiro número: ");
                double numero1 = Classes.ObterNumeroDecimal();

                Console.Write("Digite o segundo número: ");
                double numero2 = Classes.ObterNumeroDecimal();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Resultado da Adição: " + (numero1 + numero2));
                        break;
                    case 2:
                        Console.WriteLine("Resultado da Subtração: " + (numero1 - numero2));
                        break;
                    case 3:
                        Console.WriteLine("Resultado da Multiplicação: " + (numero1 * numero2));
                        break;
                    case 4:
                        if (numero2 != 0)
                        {
                            Console.WriteLine("Resultado da Divisão: " + (numero1 / numero2));
                        }
                        else
                        {
                            Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção desconhecida.");
                        break;
                }

                Console.Write("Deseja voltar ao menu principal (S/N)? ");
                escolha = Convert.ToChar(Console.ReadLine());
            } while (escolha == 'S' || escolha == 's');
            Console.ReadLine();
            Console.Clear();
        }
    }
}

