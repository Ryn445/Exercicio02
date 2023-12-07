using System;

namespace Exercicio02
{
    public class Att09
    {
        public static void Executar()
        {
            Console.WriteLine("Calculadora de idade em dias");
            Console.WriteLine();
            Console.WriteLine("Informe o ANO do seu nascimento:");
            int anoNascimento = Classes.ObterNumeroInteiro();

            int anos = 2023 - anoNascimento;
            int meses = anos * 12;
            int dias = meses * 30;

            Console.WriteLine($"Se você nasceu em {anoNascimento}, você já está com {anos} anos, {meses} meses e {dias} dias.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
