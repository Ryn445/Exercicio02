using System;

namespace Exercicio02
{
    public class Att07
    {
        public static void Executar()
        {
            Console.WriteLine("Conversão de temperatura: Fahrenheit para Celsius");
            Console.WriteLine();
            Console.WriteLine("Informe a temperatura em Fahrenheit:");
            double temperaturaFahrenheit = Classes.ObterNumeroDecimal();
            Console.WriteLine();

            double temperaturaCelsius = (temperaturaFahrenheit - 32) * 5 / 9;

            Console.WriteLine($"A temperatura de {temperaturaFahrenheit}º Fahrenheit é equivalente a {temperaturaCelsius.ToString("#0.00")}º Celsius");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
