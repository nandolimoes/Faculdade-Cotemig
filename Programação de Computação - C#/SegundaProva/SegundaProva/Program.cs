using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaProva
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;

            Console.WriteLine(" ----------------------------");
            Console.WriteLine("| TECLA | Exercício          |");
            Console.WriteLine(" ----------------------------");
            Console.WriteLine("|  F1   | Idade              |");
            Console.WriteLine(" ----------------------------");
            Console.WriteLine("|  F2   | Compra e venda     |");
            Console.WriteLine(" ----------------------------");
            Console.WriteLine("|  F3   | Operações          |");
            Console.WriteLine(" ----------------------------");
            Console.WriteLine("|  ESC  | SAIR               |");
            Console.WriteLine(" ----------------------------");

            Console.Write("Informe uma tecla: ");
            tecla = Console.ReadKey();

            switch (tecla.Key)
            {
                case ConsoleKey.F1:
                    {
                        int idade1, idade2, idade3, idade4;

                        Console.Clear();
                        Console.WriteLine(" ----------------");
                        Console.WriteLine("|   F1   | Idade |");
                        Console.WriteLine(" ---------------\n");

                        Console.WriteLine("Digite 3 idades em ordem crescente (do menor para o maior)");

                        Console.Write("Informe a 1ª idade: ");
                        idade1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Informe a 2º idade: ");
                        idade2 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Informe a 3º idade: ");
                        idade3 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Informe uma 4ª idade diferente das anteriores: ");
                        idade4 = Convert.ToInt32(Console.ReadLine());

                        if (idade1 != idade2 && idade2 != idade3 && idade1 != idade4)
                        {
                            if (idade4 > idade3)
                            {
                                Console.WriteLine("A ordem decrescente das idades é: {0}, {1}, {2}, {3}", idade4, idade3, idade2, idade1);
                            }
                            else if (idade4 > idade2 && idade3 > idade4)
                            {
                                Console.WriteLine("A ordem decrescente das idades é: {0}, {1}, {2}, {3}", idade3, idade4, idade2, idade1);
                            }
                            else if (idade4 > idade1 && idade2 > idade4)
                            {
                                Console.WriteLine("A ordem decrescente das idades é: {0}, {1}, {2}, {3}", idade3, idade2, idade4, idade1);
                            }
                            else
                            {
                                Console.WriteLine("A ordem decrescente das idades é: {0}, {1}, {2}, {3}", idade3, idade2, idade1, idade4);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Existem idades iguais");
                        }
                    }
                    break;

                 case ConsoleKey.F2:
                    {
                        string produto;
                        double compra;

                        Console.Clear();
                        Console.WriteLine(" -------------------------");
                        Console.WriteLine("|   F2   | Compra e Venda |");
                        Console.WriteLine(" -------------------------\n");

                        Console.Write("Informe o nome do produto negociado: ");
                        produto = Console.ReadLine();

                        Console.Write("Informe o valor de compra do produto {0}: ", produto);
                        compra = Convert.ToInt32(Console.ReadLine());

                        if (compra < 10)
                        {
                        Console.WriteLine("O produto {0} terá o valor de venda de {1}", produto, compra*1.7);
                        }
                        else if (compra >= 10 && compra < 30)
                        {
                        Console.WriteLine("O produto {0} terá o valor de venda de {1}", produto, compra * 1.5);
                        }
                        else if (compra >= 30 && compra < 50)
                        {
                        Console.WriteLine("O produto {0} terá o valor de venda de {1}", produto, compra * 1.4);
                        }
                        else
                        {
                        Console.WriteLine("O produto {0} terá o valor de venda de {1}", produto, compra * 1.3);
                        }
                    }
                    break;

                case ConsoleKey.F3:
                    {

                        double num1, num2;
                        char opcao;

                        Console.Clear();
                        Console.WriteLine(" -------------------------");
                        Console.WriteLine("|   F3   | Operações     |");
                        Console.WriteLine(" -------------------------\n");

                        Console.WriteLine(" ----------------------");
                        Console.WriteLine("| Menu | Operação      |");
                        Console.WriteLine(" ----------------------");
                        Console.WriteLine("|  1   | Soma          |");
                        Console.WriteLine(" ----------------------");
                        Console.WriteLine("|  2   | Subtração     |");
                        Console.WriteLine(" ----------------------");
                        Console.WriteLine("|  3   | Multiplicação |");
                        Console.WriteLine(" ----------------------");
                        Console.WriteLine("|  4   | Divisão       |");
                        Console.WriteLine(" ----------------------\n");

                        Console.Write("Informe a opção desejada: ");
                        opcao = Convert.ToChar(Console.ReadLine());

                        Console.Write("Informe o 1º número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Informe o 2º número: ");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        switch (opcao)
                        {
                            case '1':
                            {
                                    Console.WriteLine("A SOMA do valor {0} e o valor {1} é igual a {2}", num1, num2, num1+num2);
                            }
                            break;
                            case '2':
                                {
                                    Console.WriteLine("A SUBTRAÇÃO do valor {0} e o valor {1} é igual a {2}", num1, num2, num1 - num2);
                                }
                                break;
                            case '3':
                                {
                                    Console.WriteLine("A MULTIPLICAÇÃO do valor {0} e o valor {1} é igual a {2}", num1, num2, num1 * num2);
                                }
                                break;
                            case '4':
                                {
                                    Console.WriteLine("A DIVISÃO do valor {0} e o valor {1} é igual a {2}", num1, num2, num1 / num2);
                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Opção de operação inválida!");
                                }
                                break;
                        }
                    }
                    break;

                case ConsoleKey.Escape:
                    {

                        Console.Clear();
                        Console.WriteLine(" ------------------------------");
                        Console.WriteLine("|   ESC   |  SAIR DO PROGRAMA  |");
                        Console.WriteLine(" ------------------------------");
                    }
                    break;

                        default:
                    {
                        Console.WriteLine("\n Tecla {0} informada não existe no menu!", tecla.Key);
                    }
                    break;

            }

            Console.WriteLine("\n------------------------------");
            Console.WriteLine("|   Programa Finalizado       |");
            Console.WriteLine(" ------------------------------");

            Console.ReadKey();
        }
    }
}

          
       