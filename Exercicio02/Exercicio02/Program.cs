using System;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var opcao = "";
            while (opcao != "J")
            {
                Console.WriteLine("1 - Determinar o valor médio do estoque de uma peça.");
                Console.WriteLine("2 - Converter dólares para a moeda local.");
                Console.WriteLine("3 - Calcular comissões para vendedores de peças.");
                Console.WriteLine("4 - Executar operações com quatro números inteiros.");
                Console.WriteLine("5 - Calcular a quantidade de combustível necessária para uma viagem.");
                Console.WriteLine("6 - Converter temperatura de Celsius para Fahrenheit.");
                Console.WriteLine("7 - Converter temperatura de Fahrenheit para Celsius.");
                Console.WriteLine("8 - Calcular o volume de uma lata de óleo.");
                Console.WriteLine("9 - Calcular a idade em dias.");
                Console.WriteLine("10 - Avaliar relações de ordem entre dois números inteiros.");
                Console.WriteLine("11 - Trocar os valores de duas variáveis.");
                Console.WriteLine("12 - Mostrar o módulo de um número.");
                Console.WriteLine("13 - Ordenar três números inteiros em ordem decrescente.");
                Console.WriteLine("14 - Calcular a diferença entre o maior e o menor número.");
                Console.WriteLine("15 - Verificar a aprovação de um aluno, considerando recuperação.");
                Console.WriteLine("16 - Identificar o maior e o menor número em um conjunto.");
                Console.WriteLine("17 - Verificar se um número está na faixa de 0 a 9.");
                Console.WriteLine("18 - Representar um código por extenso.");
                Console.WriteLine("19 - Classificar tipos de triângulos.");
                Console.WriteLine("20 - Realizar cálculos com três valores inteiros distintos.");
                Console.WriteLine("21 - Determinar se um número é positivo ou negativo.");
                Console.WriteLine("22 - Armazenar números positivos em A e negativos em B.");
                Console.WriteLine("23 - Executar operações matemáticas.");
                Console.WriteLine("24 - Verificar propriedades entre dois números.");
                Console.WriteLine("25 - Calcular o peso ideal com base em altura e sexo.");
                Console.WriteLine("26 - Exibir números de 1 a 100 em ordem decrescente.");
                Console.WriteLine("27 - Calcular o fatorial de uma sequência de números.");
                Console.WriteLine("28 - Exibir números ímpares entre 100 e 200.");
                Console.WriteLine("29 - Exibir números de 1 a 200.");
                Console.WriteLine("30 - Imprimir uma tabuada.");
                Console.WriteLine("31 - Verificar se números em um conjunto são pares ou ímpares.");
                Console.WriteLine("32 - Calcular a média das notas de uma turma.");
                Console.WriteLine("33 - Identificar o maior e o menor número em um conjunto.");
                Console.WriteLine("34 - Contar múltiplos de 10 até 100.");
                Console.WriteLine("35 - Ler 10 valores e identificar o maior, o menor e a média.");
                Console.WriteLine("36 - Menu de conversão de base numérica.");
                Console.WriteLine("37 - Calcular o salário com horas trabalhadas e horas extras.");
                Console.WriteLine("38 - Verificar se um número é par, ímpar, positivo ou negativo.");
                Console.WriteLine("39 - Notificar indústrias com base no índice de poluição.");
                Console.WriteLine("40 - Classificar nadadores por idade.");
                Console.WriteLine("41 - Identificar o maior e o menor entre N números.");
                Console.WriteLine("42 - Calcular o número de grãos em um tabuleiro de xadrez.");
                Console.WriteLine("43 - Menu de opções: conversão de temperatura, peso ideal.");
                Console.WriteLine("44 - Sortear um número de 0 a 100 com tentativas do usuário.");
                Console.WriteLine("45 - Imprimir uma sequência de números na ordem inversa.");
                Console.WriteLine("46 - Calcular o produto escalar de dois vetores.");
                Console.WriteLine("47 - Verificar números maiores, menores e iguais a X em um vetor.");
                Console.WriteLine("48 - Identificar candidatas aptas para uma campanha publicitária.");
                Console.WriteLine("49 - Calcular o desconto de um produto.");
                Console.WriteLine("50 - Simular caixa eletrônico: saque, depósito e consulta de saldo.");
                Console.WriteLine("51 - Ler notas de alunos e calcular média e aprovação.");
                Console.WriteLine("52 - Contar ocorrências específicas em um vetor.");
                Console.WriteLine("53 - Analisar tempos de voltas em uma corrida de automóveis.");
                Console.WriteLine("54 - Imprimir elementos comuns entre dois vetores.");
                Console.WriteLine("55 - Remover espaços em branco de uma frase.");
                Console.WriteLine("56 - Calcular a média e identificar o maior número em um vetor de inteiros.");
                Console.WriteLine("57 - Imprimir vogais em uma frase.");
                Console.WriteLine("58 - Ler e imprimir números pares e múltiplos de 5 em um vetor.");
                Console.WriteLine("59 - Contar caracteres entre dois limites em ordem alfabética.");
                Console.WriteLine("60 - Verificar o quadrante com base em coordenadas x e y.");
                Console.WriteLine("61 - Calcular o salário atualizado com reajuste.");
                Console.WriteLine("62 - Calcular a hipotenusa de um triângulo.");
                Console.WriteLine("63 - Verificar se um número é par ou ímpar.");
                Console.WriteLine("64 - Menu de opções para manipulação de um vetor.");

                Console.WriteLine("J - Para encerrar o programa");
                Console.WriteLine("");

                Console.Write("Digite o número desejado :");

                opcao = Console.ReadLine().ToUpper();

                Console.Clear();

                switch (opcao)
                {
                    case "1":
                        Att01.Executar();
                        break;
                    case "2":
                        Att02.Executar();
                        break;
                    case "3":
                        Att03.Executar();
                        break;
                    case "4":
                        Att04.Executar();
                        break;
                    case "5":
                        Att05.Executar();
                        break;
                    case "6":
                        Att06.Executar();
                        break;
                    case "7":
                        Att07.Executar();
                        break;
                    case "8":
                        Att08.Executar();
                        break;
                    case "9":
                        Att09.Executar();
                        break;
                    case "10":
                        Att10.Executar();
                        break;
                    case "11":
                        Att11.Executar();
                        break;
                    case "12":
                        Att12.Executar();
                        break;
                    case "13":
                        Att13.Executar();
                        break;
                    case "14":
                        Att14.Executar();
                        break;
                    case "15":
                        Att15.Executar();
                        break;
                    case "16":
                        Att16.Executar();
                        break;
                    case "17":
                        Att17.Executar();
                        break;
                    case "18":
                        Att18.Executar();
                        break;
                    case "19":
                        Att19.Executar();
                        break;
                    case "20":
                        Att20.Executar();
                        break;
                    case "21":
                        Att21.Executar();
                        break;
                    case "22":
                        Att22.Executar();
                        break;
                    case "23":
                        Att23.Executar();
                        break;
                    case "24":
                        Att24.Executar();
                        break;
                    case "25":
                        Att25.Executar();
                        break;
                    case "26":
                        Att26.Executar();
                        break;
                    case "27":
                        Att27.Executar();
                        break;
                    case "28":
                        Att28.Executar();
                        break;
                    case "29":
                        Att29.Executar();
                        break;
                    case "30":
                        Att30.Executar();
                        break;
                    case "31":
                        Att31.Executar();
                        break;
                    case "32":
                        Att32.Executar();
                        break;
                    case "33":
                        Att33.Executar();
                        break;
                    case "34":
                        Att34.Executar();
                        break;
                    case "35":
                        Att35.Executar();
                        break;
                    case "36":
                        Att36.Executar();
                        break;
                    case "37":
                        Att37.Executar();
                        break;
                    case "38":
                        Att38.Executar();
                        break;
                    case "39":
                        Att39.Executar();
                        break;
                    case "40":
                        Att40.Executar();
                        break;
                    case "41":
                        Att41.Executar();
                        break;
                    case "42":
                        Att42.Executar();
                        break;
                    case "43":
                        Att43.Executar();
                        break;
                    case "44":
                        Att44.Executar();
                        break;
                    case "45":
                        Att45.Executar();
                        break;
                    case "46":
                        Att46.Executar();
                        break;
                    case "47":
                        Att47.Executar();
                        break;
                    case "48":
                        Att48.Executar();
                        break;
                    case "49":
                        Att49.Executar();
                        break;
                    case "50":
                        Att50.Executar();
                        break;
                    case "51":
                        Att51.Executar();
                        break;
                    case "52":
                        Att52.Executar();
                        break;
                    case "53":
                        Att53.Executar();
                        break;
                    case "54":
                        Att54.Executar();
                        break;
                    case "55":
                        Att55.Executar();
                        break;
                    case "56":
                        Att56.Executar();
                        break;
                    case "57":
                        Att57.Executar();
                        break;
                    case "58":
                        Att58.Executar();
                        break;
                    case "59":
                        Att59.Executar();
                        break;
                    case "60":
                        Att60.Executar();
                        break;
                    case "61":
                        Att61.Executar();
                        break;
                    case "62":
                        Att62.Executar();
                        break;
                    case "63":
                        Att63.Executar();
                        break;
                    case "64":
                        Att64.Executar();
                        break;
                    case "J":
                        Console.WriteLine("Tchauzinho até depois hahaha.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida, escolha uma correta por favor!.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
               
                }
            }
        }
    }
}