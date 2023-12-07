using System;

namespace Exercicio02
{
    public class Att11
    {
        public static void Executar()
        {
            Console.WriteLine("Troca de valores entre duas variáveis");
            Console.WriteLine("Informe o PRIMEIRO NÚMERO (A):");
            int A = Classes.ObterNumeroInteiro();
            Console.WriteLine("Informe o SEGUNDO NÚMERO (B):");
            int B = Classes.ObterNumeroInteiro();

            Console.WriteLine($"Os dois valores foram digitados na seguinte ordem: A = {A} e B = {B}");

            int auxiliar = A;
            A = B;
            B = auxiliar;

            Console.WriteLine($"Os valores trocados são: A = {A} e B = {B}");

            Console.ReadKey();
            Console.Clear();
        }
    }
}

