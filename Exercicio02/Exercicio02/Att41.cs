using System;

namespace Exercicio02
{
    public class Att41
    {
        public static void Executar()
        {
            Console.WriteLine("Este programa irá determinar a categoria de um nadador com base em sua idade.");
            Console.WriteLine();

            Console.Write("Digite a idade do nadador: ");
            int idade = Classes.ObterNumeroInteiro();

            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("O nadador está na categoria Infantil A.");
            }
            else if (idade >= 8 && idade <= 11)
            {
                Console.WriteLine("O nadador está na categoria Infantil B.");
            }
            else if (idade >= 12 && idade <= 13)
            {
                Console.WriteLine("O nadador está na categoria Juvenil A.");
            }
            else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("O nadador está na categoria Juvenil B.");
            }
            else if (idade >= 18)
            {
                Console.WriteLine("O nadador está na categoria Adultos.");
            }
            else
            {
                Console.WriteLine("Idade fora das faixas das categorias disponíveis.");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
