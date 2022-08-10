using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista15
{
    class Program
    {
        static Random numeroRandom = new Random();

        static ConsoleKeyInfo lerTecla;

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("| COD | EXERCÍCIO     |");
            Console.WriteLine("----------------------");
            Console.WriteLine("|  F1 | EXERCÍCIO 1   |");
            Console.WriteLine("----------------------");
            Console.WriteLine("|  F2 | EXERCÍCIO 2   |");
            Console.WriteLine("----------------------");
            Console.WriteLine("|  F3 | EXERCÍCIO 3   |");
            Console.WriteLine("----------------------");
            Console.WriteLine("|  F4 | EXERCÍCIO 4   |");
            Console.WriteLine("----------------------");
            Console.WriteLine("|  F5 | EXERCÍCIO 5   |");
            Console.WriteLine("----------------------");
            Console.WriteLine("|  F6 | EXERCÍCIO 6   |");
            Console.WriteLine("----------------------");
            Console.WriteLine("|  F7 | EXERCÍCIO 7   |");
            Console.WriteLine("----------------------");
            Console.WriteLine("|  F8 | EXERCÍCIO 8   |");
            Console.WriteLine("----------------------");
            Console.WriteLine("| ESC | SAIR          |");
            Console.WriteLine("----------------------");

            lerTecla = Console.ReadKey();

            switch (lerTecla.Key)
            {

                case ConsoleKey.F1:
                    {
                        double nota1, nota2, nota3;

                        Console.Clear();
                        Console.WriteLine("----------------------");
                        Console.WriteLine("|  F1 | EXERCÍCIO 1   |");
                        Console.WriteLine("----------------------");

                        Console.Write("Informe a 1ª nota: ");
                        nota1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Informe a 2ª nota: ");
                        nota2 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Informe a 3ª nota: ");
                        nota3 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("A média foi: {0}", Math.Round(CalculoMedia(nota1, nota2, nota3)), 2);

                        Console.WriteLine("Pressione uma tecla para retornar ao menu principal");

                        Console.ReadKey();
                        Menu();
                    }
                    break;

                case ConsoleKey.F2:
                    {
                        int numeroMes;

                        Console.Clear();
                        Console.WriteLine("----------------------");
                        Console.WriteLine("|  F2 | EXERCÍCIO 2   |");
                        Console.WriteLine("----------------------");

                        Console.Write("Digita o nº do mês do primeiro semestre desejado: ");

                        numeroMes = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(Mes(numeroMes));

                        Console.WriteLine("Pressione uma tecla para retornar ao menu principal");

                        Console.ReadKey();

                        Menu();
                    }
                    break;

                case ConsoleKey.F3:
                    {
                        int numero;

                        Console.Clear();
                        Console.WriteLine("----------------------");
                        Console.WriteLine("|  F3 | EXERCÍCIO 3   |");
                        Console.WriteLine("----------------------");

                        Console.Write("Digite um número a ser avaliado se é positivo ou negativo: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(NumeroPositivo(numero) ? "Número Positivo" : "Número Negativo");

                        Console.WriteLine("Pressione uma tecla para retornar ao menu principal");

                        Console.ReadKey();

                        Menu();
                    }
                    break;

                case ConsoleKey.F4:
                    {
                        int numero1, numero2;

                        Console.Clear();
                        Console.WriteLine("----------------------");
                        Console.WriteLine("|  F4 | EXERCÍCIO 4   |");
                        Console.WriteLine("----------------------");

                        Console.Write("Digite o 1º número a ser comparado: ");
                        numero1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Digite o 2º número a ser comparado: ");
                        numero2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("O maior número é: {0}", MaiorNumero(numero1, numero2));

                        Console.WriteLine("Pressione uma tecla para retornar ao menu principal");

                        Console.ReadKey();

                        Menu();
                    }
                    break;

                case ConsoleKey.F5:
                    {
                        int numero1, numero2;

                        Console.Clear();
                        Console.WriteLine("----------------------");
                        Console.WriteLine("|  F5 | EXERCÍCIO 5   |");
                        Console.WriteLine("----------------------");

                        Console.Write("Digite o 1º número a ser comparado: ");
                        numero1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Digite o 2º número a ser comparado: ");
                        numero2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("O menor número é: {0}", MenorNumero(numero1, numero2));

                        Console.WriteLine("Pressione uma tecla para retornar ao menu principal");

                        Console.ReadKey();

                        Menu();
                    }
                    break;

                case ConsoleKey.F6:
                    {

                        Console.Clear();
                        Console.WriteLine("----------------------");
                        Console.WriteLine("|  F6 | EXERCÍCIO 6   |");
                        Console.WriteLine("----------------------");

                        Console.WriteLine("O número que sorteado no dado foi: {0}", Dado());

                        Console.WriteLine("Pressione uma tecla para retornar ao menu principal");

                        Console.ReadKey();

                        Menu();
                    }
                    break;

                case ConsoleKey.F7:
                    {
                        int quant;
                        Console.Clear();
                        Console.WriteLine("----------------------");
                        Console.WriteLine("|  F7 | EXERCÍCIO 7   |");
                        Console.WriteLine("----------------------");

                        Console.Write("Informe quantas vezes deseja lançar o dado: ");
                        quant = Convert.ToInt32(Console.ReadLine());

                        LancaDado(quant);

                        Console.WriteLine("Pressione uma tecla para retornar ao menu principal");

                        Console.ReadKey();

                        Menu();
                    }
                    break;

                case ConsoleKey.F8:
                    {
                        int numero;

                        Console.Clear();
                        Console.WriteLine("----------------------");
                        Console.WriteLine("|  F8 | EXERCÍCIO 8   |");
                        Console.WriteLine("----------------------");

                        Console.Write("Digite um número para saber se é primo: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("O número {0} {1}", numero, ValidaPrimo(numero) ? "é primo" : "não é primo");

                        Console.WriteLine("Pressione uma tecla para retornar ao menu principal");

                        Console.ReadKey();

                        Menu();
                    }
                    break;

            }
        }

        /*Exercício 1) Fazer um programa para obter três notas e calcular e exibir a sua média, usando uma função para o cálculo da média.*/

        static double CalculoMedia(double pNota1, double pNota2, double pNota3)
        {
            return (pNota1 + pNota2 + pNota3) / 3;
        }

        /*Exercício 2) Criar um método que receba um número que corresponda há um mês no primeiro trimestre e escreva o nome do mês correspondente. 
         Caso o usuário digite o número fora do intervalo, deverá aparecer inválido. 
         Utilize uma função chamada Mes.*/

        static string Mes(int pNumero)
        {
            string resposta; //string resposta = "";

            if (pNumero > 0 && pNumero < 4)
            {
                switch (pNumero)
                {
                    case 1:
                        {
                            resposta = "Janeiro";
                        }
                        break;

                    case 2:
                        {
                            resposta = "Fevereiro";
                        }
                        break;

                    default: //case 3:
                        {
                            resposta = "Março";
                        }
                        break;
                }
            }
            else
            {
                resposta = "Número inválido, fora do intervalo";
            }
            return resposta;
        }

        /*Exercício 3) Crie um método que receba um número inteiro e informe se ele é positivo (true) ou negativo (false) através de um retorno com boolean.*/

        static bool NumeroPositivo(int pNumero)
        {
            return pNumero >= 0; // ? true : false;         
        }

        /*Exercício 4) Crie um método que receba 2 números e retorne o maior valor.*/

        static int MaiorNumero(int pNumero1, int pNumero2)
        {
            return pNumero1 >= pNumero2 ? pNumero1 : pNumero2;
        }

        /*Exercício 5) Crie um método que receba 2 números e retorne o menor valor*/

        static int MenorNumero(int pNumero1, int pNumero2)
        {
            return pNumero1 <= pNumero2 ? pNumero1 : pNumero2;
        }

        /*Exercício 6) Crie um método chamado Dado() que retorna, através de sorteio, um número de 1 até 6.*/

        static int Dado()
        {
            return numeroRandom.Next(1, 7);
        }

        /*Exercício 7) Utilize o método da questão 6 e lance o dado quantas vezes o usuario quiser. 
          Conte quantas vezes cada número saiu.*/

        static void LancaDado(int pQuantidade)
        {
            int numeroDado, numero1 = 0, numero2 = 0, numero3 = 0, numero4 = 0, numero5 = 0, numero6 = 0;

            for (int i = 0; i < pQuantidade; i++)
            {
                numeroDado = Dado();

                switch (numeroDado)
                {
                    case 1:
                        {
                            numero1++;
                        }
                        break;

                    case 2:
                        {
                            numero2++;
                        }
                        break;

                    case 3:
                        {
                            numero3++;
                        }
                        break;

                    case 4:
                        {
                            numero4++;
                        }
                        break;

                    case 5:
                        {
                            numero5++;
                        }
                        break;

                    default:
                        {
                            numero6++;
                        }
                        break;
                }
            }
            Console.WriteLine("O numero 1 foi sorteado {0} vezes", numero1);
            Console.WriteLine("O numero 2 foi sorteado {0} vezes", numero2);
            Console.WriteLine("O numero 3 foi sorteado {0} vezes", numero3);
            Console.WriteLine("O numero 4 foi sorteado {0} vezes", numero4);
            Console.WriteLine("O numero 5 foi sorteado {0} vezes", numero5);
            Console.WriteLine("O numero 6 foi sorteado {0} vezes", numero6);
        }

        /*Exercício 8) Construa um método do tipo boolean, para verificar se um determinado número é primo ou não.*/

        static bool ValidaPrimo (int pNumero)
            {
            int quantDivisores = 0;

            for (int i = 1; i <= pNumero; i++)
            {
                if(pNumero % i == 0)
                {
                    quantDivisores++;
                }
            }
            return quantDivisores == 2;
            }

        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }      
    }
}