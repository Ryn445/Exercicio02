using System;

namespace Exercicio02
{
    public class Att01
    {
        public static void Executar()
        {
            Console.WriteLine("CÁLCULO DA MÉDIA DE ESTOQUE MÍNIMO E MÁXIMO");

            Console.Write("Nome do produto: ");
            string nomeProduto = Console.ReadLine();

            Console.Write("Estoque mínimo: ");
            int estoqueMinimo = Classes.ObterNumeroInteiro();

            Console.Write("Estoque máximo: ");
            int estoqueMaximo = Classes.ObterNumeroInteiro();

            int media = (estoqueMinimo + estoqueMaximo) / 2;

            Console.WriteLine($"A média de {nomeProduto} é: {media}");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
