using System;

namespace Exercicio02
{
    public class Att03
    {
        public static void Executar()
        {
            Console.WriteLine("Cálculo de comissão para vendedores de produtos");
            Console.WriteLine();

            Console.Write("Digite o nome do vendedor: ");
            string nomeVendedor = Console.ReadLine();

            Console.Write("Digite o código do vendedor: ");
            int codigoVendedor = Classes.ObterNumeroInteiro();
            Console.WriteLine();

            Console.Write("Digite o nome do produto que está sendo vendido: ");
            string nomeProduto = Console.ReadLine();
            Console.WriteLine();

            Console.Write($"Digite o preço unitário do {nomeProduto} que o cliente está levando: ");
            double precoUnitario = Classes.ObterNumeroDecimal();
            Console.WriteLine();

            Console.Write($"Digite a quantidade de {nomeProduto} que o cliente está levando: ");
            int quantidadeVendida = Classes.ObterNumeroInteiro();
            Console.WriteLine();

            double valorTotal = precoUnitario * quantidadeVendida;
            double comissao = valorTotal * 0.05;

            Console.WriteLine($"O valor total dos produtos vendidos é R$ {valorTotal}");
            Console.WriteLine($"O vendedor(a) {nomeVendedor} com código {codigoVendedor} receberá R$ {comissao} de comissão pela venda do {nomeProduto}");

            Console.ReadLine();
            Console.Clear();
        }
    }
}
