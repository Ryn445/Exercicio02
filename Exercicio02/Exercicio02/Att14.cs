using System;

namespace Exercicio02
{
    public class Att14
    {
        public static void Executar()
        {
            Console.WriteLine("Cálculo da Diferença entre Dois Números");
            Console.WriteLine();
            Console.Write("Digite o primeiro número: ");
            int primeiroNumero = Classes.ObterNumeroInteiro();

            Console.Write("Digite o segundo número: ");
            int segundoNumero = Classes.ObterNumeroInteiro();

            int diferenca;

            if (primeiroNumero > segundoNumero)
            {
                diferenca = primeiroNumero - segundoNumero;
                Console.WriteLine($"A diferença entre {primeiroNumero} e {segundoNumero} é: {diferenca}");
            }
            else if (segundoNumero > primeiroNumero)
            {
                diferenca = segundoNumero - primeiroNumero;
                Console.WriteLine($"A diferença entre {segundoNumero} e {primeiroNumero} é: {diferenca}");
            }
            else
            {
                Console.WriteLine("Os números são iguais, portanto, a diferença é 0.");
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
