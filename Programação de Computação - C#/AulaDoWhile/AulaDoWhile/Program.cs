using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo lerTecla;
            bool continua = true;

            do
            {
                Console.Clear();
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("| COD  | Exercício            | ");
                Console.WriteLine("------------------------------");
                Console.WriteLine("|  F1  | Número Primo         | ");
                Console.WriteLine("------------------------------");
                Console.WriteLine("|  F2  | Encontrar o 0 e Soma | ");
                Console.WriteLine("------------------------------");
                Console.WriteLine("|  F3  | Cronograma           | ");
                Console.WriteLine("------------------------------");
                Console.WriteLine("| ESC  |  SAIR                | ");
                Console.WriteLine("------------------------------");

                Console.Write("Digite a opção do exercício desejado: ");
                lerTecla = Console.ReadKey();

                if (lerTecla.Key == ConsoleKey.F1 || lerTecla.Key == ConsoleKey.F2 
                    || lerTecla.Key == ConsoleKey.F3 || lerTecla.Key == ConsoleKey.Escape)
                {
                    continua = false;
                }
                else
                {
                    Console.WriteLine("\n Opção errada: Escolha uma das opções acima \n");
                    Console.ReadKey();
                }

            }while (continua);
            

            switch (lerTecla.Key)
                {
                    case ConsoleKey.F1:
                        {
                            //Escreva um algoritmo que leia um número do teclado até que encontre um número primo.

                            Console.Clear();
                            Console.WriteLine("------------------------------");
                            Console.WriteLine("|  F1  | Número Primo         | ");
                            Console.WriteLine("------------------------------");

                            int numero, divisores;

                            do
                            {
                                Console.WriteLine("Digite um número inteiro: ");
                                numero = Convert.ToInt32(Console.ReadLine());
                                divisores = 0;

                                for (int i = 1; i <= numero; i++)
                                {
                                    if (numero % i == 0)
                                    {
                                        divisores++;
                                    }
                                }
                            }
                            while (divisores != 2);
                        }
                        break;

                    case ConsoleKey.F2:
                        {
                            //Crie um programa que leia um número do teclado até que encontre um número igual a zero.
                            //No final, mostre a soma dos números digitados.

                            Console.Clear();
                            Console.WriteLine("------------------------------");
                            Console.WriteLine("|  F2  | Encontrar o 0 e Soma | ");
                            Console.WriteLine("------------------------------");

                            int numero, soma = 0;

                            do
                            {
                                Console.WriteLine("Digite um número inteiro: ");
                                numero = Convert.ToInt32(Console.ReadLine());
                                soma += numero;

                            }
                            while (numero != 0);

                            Console.WriteLine("Soma: {0}\n", soma);

                        }
                        break;

                    case ConsoleKey.F3:
                        {

                            //Construa um programa que imprime a soma de todos os valores positivos digitados pelo usuário até que ele digite um número negativo.
                            //Apresente no final a quantidade de números positivos digitados e a soma.

                            Console.Clear();
                            Console.WriteLine("------------------------------");
                            Console.WriteLine("|  F3  | Cronograma           | ");
                            Console.WriteLine("------------------------------");
                        }
                        break;

                    case ConsoleKey.Escape:
                        {
                            Console.Clear();
                            Console.WriteLine("------------------------------");
                            Console.WriteLine("|    VOCÊ SAIU DO PROGRAMA    | ");
                            Console.WriteLine("------------------------------");
                        }
                        break;

                
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("|       FIM DO PROGRAMA       | ");
            Console.WriteLine("------------------------------");

            Console.ReadKey();
            






            
        }
    }
}
