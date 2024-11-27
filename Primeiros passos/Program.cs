using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiros_passos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1- Escreva um programa que verifique se um número fornecido pelo usuário é positivo, negativo ou zero.

            int numero = 0;

            Console.Write("Digite um número para validar: ");
            numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("O número digitado é NEGATIVO");
            }
            else if (numero > 0)
            {
                Console.WriteLine("O número digitado é POSITIVO");
            }
            else if (numero == 0)
            {
                Console.WriteLine("O número digitado é ZERO");
            }

            //2 - Escreva um programa que leia um mês do ano e informe quantos dias ele tem.

            int mes = 0;

            Console.WriteLine("Informe um mês: ");
            mes = int.Parse(Console.ReadLine());

            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                Console.WriteLine("O mês que voce digitou tem 31 dias ");
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                Console.WriteLine("O mês escolhido tem 30 dias");
            }
            else if (mes == 2)
            {
                Console.WriteLine("esse mês tem 28 dias");
            }

            /*3 - Faça um programa que leia a nota de um aluno e informe se ele está aprovado(nota maior ou igual a 7), 
            em recuperação(nota entre 5 e 7)ou reprovado (nota menor que 5).*/

            int nota = 0;
            Console.WriteLine("Digite qual foi sua nota: ");
            nota = int.Parse(Console.ReadLine());

            if (nota >= 7)
            {
                Console.WriteLine("Você esta aprovado: ");
            }
            else if (nota == 5 || nota == 6)
            {
                Console.WriteLine("Você esta em recuperação: ");
            }
            else if (nota < 5)
            {
                Console.WriteLine("Infelizmente você reprovou: ");
            }

            //4 - Calcule a soma de todos os números de 1 a 100 utilizando um laço de repetição.

            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                soma += i;
            }
            Console.WriteLine("A soma dos números de 1 a 100 é igual: " + soma);


            //5 - Implemente uma contagem regressiva de 10 até 0 utilizando um laço de repetição.

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            /*6 - Faça um programa que leia o nome de um aluno e suas três notas, calcule a média e informe se ele está aprovado
            (média maior ou igual a 7) ou reprovado.*/

            Console.WriteLine("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota: ");
            float nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            float nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            float nota3 = float.Parse(Console.ReadLine());

            float media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("A média do aluno {nome} é {media:F2}");

            if (media >= 7)
            {
                Console.WriteLine("Situação: Aprovado");
            }
            else
            {
                Console.WriteLine("Situação: Reprovado");
            }

            //7 - Faça um programa que peça ao usuário para digitar um ano e verifique se é bissexto.

            Console.WriteLine("Digite um ano: ");
            int ano = int.Parse(Console.ReadLine());

            if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
            {
                Console.WriteLine($"O ano {ano} é bissexto.");
            }
            else
            {
                Console.WriteLine($"O ano {ano} não é bissexto.");
            }

            /*8 - Jogo da adivinhação: Implemente um jogo de adivinhação onde o usuário tem que adivinhar um número entre 1 e 100.
            O programa deve dar dicas de "maior" ou "menor" após cada tentativa, utilizando um laço de repetição.*/

            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int tentativa = 0;
            int chute;
            bool acertou = false;

            Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
            Console.WriteLine("Tente adivinhar o número secreto entre 1 e 100.");

            while (!acertou)
            {
                Console.Write("Digite seu palpite: ");
                if (int.TryParse(Console.ReadLine(), out chute))
                {
                    tentativa++;

                    if (chute == numeroSecreto)
                    {
                        Console.WriteLine($"Parabéns! Você acertou o número secreto {numeroSecreto} em {tentativa} tentativas.");
                        acertou = true;
                    }
                    else if (chute < numeroSecreto)
                    {
                        Console.WriteLine("O número secreto é maior. Tente novamente.");
                    }
                    else
                    {
                        Console.WriteLine("O número secreto é menor. Tente novamente.");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, digite um número válido.");
                }
            }
        }
    }
}
