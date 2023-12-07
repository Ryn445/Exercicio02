using System;

namespace Exercicio02
{
    public class Att50
    {
        public static void Executar()
        {
            Random random = new Random();
            int numeroSorteado = random.Next(0, 101);
            int tentativas = 0;
            string entrada;

            Console.WriteLine("Tente adivinhar o número que foi sorteado entre 0 e 100! Digite 'X' para sair.");

            while (true)
            {
                tentativas++;
                Console.Write("Digite um número: ");
                entrada = Console.ReadLine();

                if (entrada.ToUpper() == "X")
                {
                    Console.WriteLine("Você escolheu sair do jogo. Até a próxima!");
                    break;
                }

                int numeroEscolhido;
                if (!int.TryParse(entrada, out numeroEscolhido))
                {
                    Console.WriteLine("Entrada inválida. Digite um número válido ou 'X' para sair.");
                    continue;
                }

                if (numeroEscolhido < numeroSorteado)
                {
                    Console.WriteLine("O número sorteado é maior! Tente novamente.");
                }
                else if (numeroEscolhido > numeroSorteado)
                {
                    Console.WriteLine("O número sorteado é menor! Tente novamente.");
                }
                else
                {
                    Console.WriteLine($"Parabéns, você acertou o número em {tentativas} tentativas!");
                    break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
