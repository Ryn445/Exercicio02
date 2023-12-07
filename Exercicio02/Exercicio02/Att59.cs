using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Att59
    {
        public static void Executar()
        {
            Console.WriteLine("Este programa pede duas letras em A e Z e te fala quantos caracteres existem entre eles");
            Console.WriteLine();

            Console.Write("Digite o primeiro caractere (A-Z): ");
            char primeiroCaractere = Classes.ObterCaractereAlfabetico();

            Console.Write("Digite o segundo caractere (A-Z): ");
            char segundoCaractere = Classes.ObterCaractereAlfabetico();

            if (primeiroCaractere >= segundoCaractere)
            {
                Console.WriteLine("Erro: o primeiro caractere deve ser alfabeticamente anterior ao segundo caractere.");
                return;
            }

            int numeroCaracteres = segundoCaractere - primeiroCaractere - 1;

            Console.WriteLine($"O número de caracteres entre {primeiroCaractere} e {segundoCaractere} é: {numeroCaracteres}");

            Console.ReadKey();
            Console.Clear();

        }
    }
}
