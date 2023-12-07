using System;

namespace Exercicio02
{
    public class Att02
    {
        public static void Executar()
        {
        
            Console.Clear();

            Console.WriteLine("COTAÇÃO DÓLAR PARA REAL");
            Console.WriteLine();

            Console.Write("quanto está o dolar hoje: ");
            double Cota_Dolar = Classes.ObterNumeroDecimal();

            Console.Write("Informe a quantidade de Dólares que deseja trocar por Reais: ");
            double QuantDoalr = Classes.ObterNumeroDecimal();

            double ValorFinal = QuantDoalr * Cota_Dolar;

            Console.WriteLine($"A quantia de Dólares informada equivale a R$ {ValorFinal.ToString("#0.00")}");

            Console.ReadKey();
            Console.Clear();
        }

        
    }
}
