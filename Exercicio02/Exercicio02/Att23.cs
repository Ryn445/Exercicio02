using System;

namespace Exercicio02
{
    public class Att23
    {
        public static void Executar()
        {
            Console.WriteLine("Calculadora: Escolha a operação desejada e informe os números correspondentes");
            Console.WriteLine();

            int escolha;
            double numero1, numero2, resultado;

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.Write("Digite o número da operação desejada: ");
            escolha = Classes.ObterNumeroInteiro();

            Console.Write("Digite o primeiro número: ");
            numero1 = Classes.ObterNumeroDecimal();

            Console.Write("Digite o segundo número: ");
            numero2 = Classes.ObterNumeroDecimal();

            switch (escolha)
            {
                case 1:
                    resultado = numero1 + numero2;
                    Console.WriteLine($"Resultado da Adição: {resultado}");
                    break;
                case 2:
                    resultado = numero1 - numero2;
                    Console.WriteLine($"Resultado da Subtração: {resultado}");
                    break;
                case 3:
                    resultado = numero1 * numero2;
                    Console.WriteLine($"Resultado da Multiplicação: {resultado}");
                    break;
                case 4:
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine($"Resultado da Divisão: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
