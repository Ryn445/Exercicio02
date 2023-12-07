using System;

namespace Exercicio02
{
    public class Att06
    {
        public static void Executar()
        {
            Console.WriteLine("Conversão de temperatura: Celsius para Fahrenheit");
            Console.WriteLine();
            Console.WriteLine("Informe a temperatura em graus Celsius:");
            double temperaturaCelsius = Classes.ObterNumeroDecimal();
            Console.WriteLine();

            double temperaturaFahrenheit = (9 * temperaturaCelsius + 160) / 5;

            Console.WriteLine($"A temperatura de {temperaturaCelsius}º Celsius é equivalente a {temperaturaFahrenheit}º Fahrenheit");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
