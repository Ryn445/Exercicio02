using System;

namespace Exercicio02
{
    public class Att24
    {
        public static void Executar()
        {
            Console.WriteLine("Este programa verificará propriedades dos números que você informar.");
            Console.WriteLine();

            char continuar;

            Console.Write("Digite o primeiro número inteiro: ");
            int num1 = Classes.ObterNumeroInteiro();

            Console.Write("Digite o segundo número inteiro: ");
            int num2 = Classes.ObterNumeroInteiro();

            do
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Verificar se um dos números é múltiplo do outro");
                Console.WriteLine("2 - Verificar se os dois números são pares");
                Console.WriteLine("3 - Verificar se a média dos dois números é maior ou igual a 7");
                Console.WriteLine("4 - Sair");

                int opcao = Classes.ObterNumeroInteiro();
              

                switch (opcao)
                {
                    case 1:
                        if (num1 % num2 == 0 || num2 % num1 == 0)
                        {
                            Console.WriteLine("Um dos números é múltiplo do outro.");
                        }
                        else
                        {
                            Console.WriteLine("Nenhum dos números é múltiplo do outro.");
                        }
                        break;
                    case 2:
                        if (num1 % 2 == 0 && num2 % 2 == 0)
                        {
                            Console.WriteLine("Ambos os números são pares.");
                        }
                        else
                        {
                            Console.WriteLine("Ambos os números não são pares.");
                        }
                        break;
                    case 3:
                        double media = (num1 + num2) / 2.0;
                        if (media >= 7)
                        {
                            Console.WriteLine("A média dos dois números é maior ou igual a 7.");
                        }
                        else
                        {
                            Console.WriteLine("A média dos dois números é menor que 7.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.Write("\nDeseja informar uma nova opção? (S/N): ");
                continuar = Convert.ToChar(Console.ReadLine().ToUpper());

            } while (continuar == 'S');
            Console.ReadLine();
            Console.Clear();
        }
    }
}

