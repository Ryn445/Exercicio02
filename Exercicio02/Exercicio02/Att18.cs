using System;

namespace Exercicio02
{
    public class Att18
    {
        public static void Executar()
        {
            Console.WriteLine("Informe um código e o console dirá se é válido ou não e mostrará na tela.");
            Console.WriteLine();

            Console.Write("Digite um número inteiro: ");
            Console.WriteLine();

            if (int.TryParse(Console.ReadLine(), out int codigo))
            {
                Classes.ValidarCodigo(codigo);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Certifique-se de digitar um número inteiro.");
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}