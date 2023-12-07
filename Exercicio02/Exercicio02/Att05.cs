using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Att05
    {
        public static void Executar()
        {
            Console.WriteLine("Cálculo de combustível, considerando que o carro faz em média 12 km por litro");
            Console.WriteLine();
            Console.WriteLine("Informe a MÉDIA de consumo do veículo em KM/Litro (exemplo: 12 km/l):");
            double mediaLitro = Classes.ObterNumeroDecimal();
            Console.WriteLine("Informe o VALOR do litro de combustível:");
            double custoLitro = Classes.ObterNumeroDecimal();
            Console.WriteLine("Informe o TEMPO ESTIMADO PARA A VIAGEM (em horas):");
            double tempoViagem = Classes.ObterNumeroDecimal();
            Console.WriteLine("Informe a VELOCIDADE MÉDIA em KM durante o percurso:");
            double velocidadeMedia = Classes.ObterNumeroDecimal();

            double distanciaPercorrida = tempoViagem * velocidadeMedia;
            double consumoCombustivel = distanciaPercorrida / mediaLitro;
            double custoViagem = distanciaPercorrida / custoLitro;

            Console.WriteLine($"A DISTÂNCIA percorrida é de: {distanciaPercorrida} KM");
            Console.WriteLine($"O CONSUMO de combustível é de: {consumoCombustivel} Litros");
            Console.WriteLine($"O VALOR gasto nesta viagem é de: R$ {custoViagem.ToString("#0.00")}");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
