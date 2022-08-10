using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_EstruturasCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;

            Console.WriteLine(" ----------------------------");
            Console.WriteLine("| TECLA | Exercício          |");
            Console.WriteLine(" ----------------------------");
            Console.WriteLine("|  F1   | Ordem Crescente    |");
            Console.WriteLine(" ----------------------------");
            Console.WriteLine("|  F2   | Plano de saúde     |");
            Console.WriteLine(" ----------------------------");
            Console.WriteLine("|  F3   | Carro              |");
            Console.WriteLine(" ----------------------------");
            Console.WriteLine("|  F4   | Triângulo          |");
            Console.WriteLine(" ----------------------------");
            Console.WriteLine("|  F5   | Prestação          |");
            Console.WriteLine(" ----------------------------");
            Console.WriteLine("|  F6   | SalárioxEmpréstimo |");
            Console.WriteLine(" ----------------------------");
            Console.WriteLine("|  ESC  | SAIR               |");
            Console.WriteLine(" ----------------------------");

            Console.Write("Informe uma tecla: ");
            tecla = Console.ReadKey();

            switch (tecla.Key)
            {
                case ConsoleKey.F1:
                    {
                        int numero1, numero2, numero3;

                        Console.Clear();
                        Console.WriteLine(" -------------------------");
                        Console.WriteLine("|   F1   | Ordem Crescente |");
                        Console.WriteLine(" -------------------------");

                        Console.WriteLine("Informe o 1º número: ");
                        numero1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o 2º número: ");
                        numero2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o 3º número: ");
                        numero3 = Convert.ToInt32(Console.ReadLine());

                        if (numero1 != numero2 && numero2 != numero3)
                        {
                            if(numero1 < numero2 && numero1 < numero3)
                            {
                                if(numero2 < numero3)
                                {
                                    Console.WriteLine("{0}, {1}, {2}", numero1, numero2, numero3);
                                }
                                else
                                {
                                    Console.WriteLine("{0}, {1}, {2}", numero1, numero3, numero3);
                                }
                            }
                            else if (numero2 < numero1 && numero2 < numero3)
                            {
                                if ( numero1 > numero3)
                                        {
                                    Console.WriteLine("{0}, {1}, {2}", numero2, numero3, numero1);
                                }
                                else
                                {
                                    Console.WriteLine("{0}, {1}, {2}", numero2, numero1, numero3);
                                }
                            }
                            else if (numero3 < numero1 && numero3 < numero2)
                            {
                                if (numero1 > numero2)
                                {
                                    Console.WriteLine("{0}, {1}, {2}", numero3, numero2, numero1);
                                }
                                else
                                {
                                    Console.WriteLine("{0}, {1}, {2}", numero3, numero1, numero2);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Existem números iguais");
                        }

                        
                    }
                    break;
                case ConsoleKey.F2:
                    {
                        /*Um determinado grupo hospitalar está se organizando para oferecer um plano de saúde. 
                         * Para facilitar a venda ela pretende disponibilizar na internet um simulador, onde o usuário baixa o software, 
                         * informa sua idade e tipo de internação desejada (semi-privativa ou privativa) e o simulador apresenta o valor a ser pago, conforme a tabela abaixo:*/

                        int idade;
                        ConsoleKeyInfo internacao;
                        

                        Console.Clear();
                        Console.WriteLine(" -------------------------");
                        Console.WriteLine("|   F2   | Plano de saúde  |");
                        Console.WriteLine(" -------------------------");

                        Console.Write("Informe a sua idade: ");
                        idade = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Aperte a tecla S para Semi-Privativa ou P para Privativa: ");
                        internacao = Console.ReadKey();

                        switch(internacao.Key)
                        {
                            case ConsoleKey.S:
                                {
                                    if (idade >= 0 && idade <= 28)
                                    {
                                        Console.WriteLine("\n Pela idade {0} o valor a ser pago pelo leito Semi-Privativo é de R$ 78,65", idade);
                                    }
                                    else if (idade >= 29 && idade <= 33)
                                    {
                                        Console.WriteLine("\n Pela idade {0} o valor a ser pago pelo leito Semi-Privativo é de R$ 111,00", idade);
                                    }
                                    else if (idade >= 34 && idade <= 43)
                                    {
                                        Console.WriteLine("\n Pela idade {0} o valor a ser pago pelo leito Semi-Privativo é de R$ 143,30", idade);
                                    }
                                    else if (idade >= 44 && idade <= 48)
                                    {
                                        Console.WriteLine("\n Pela idade {0} o valor a ser pago pelo leito Semi-Privativo é de R$ 175,60", idade);
                                    }
                                    else if (idade >= 49 && idade <= 53)
                                    {
                                        Console.WriteLine("\n Pela idade {0} o valor a ser pago pelo leito Semi-Privativo é de R$ 207,90", idade);
                                    }
                                    else if (idade >= 54 && idade <= 58)
                                    {
                                        Console.WriteLine("\n Pela idade {0} o valor a ser pago pelo leito Semi-Privativo é de R$ 272,60", idade);
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n Pela idade {0} o valor a ser pago pelo leito Semi-Privativo é de R$ 337,30", idade);
                                    }
                                }
                                break;

                            case ConsoleKey.P:
                                {
                                    if (idade >= 0 && idade <= 28)
                                    {
                                        Console.WriteLine("\n Pela idade {0} o valor a ser pago pelo leito Privativo é de R$ 114,90", idade);
                                    }
                                    else if (idade >= 29 && idade <= 33)
                                    {
                                        Console.WriteLine("\n Pela idade {0} o valor a ser pago pelo leito Privativo é de R$ 165,40", idade);
                                    }
                                    else if (idade >= 34 && idade <= 43)
                                    {
                                        Console.WriteLine("\n Pela idade {0} o valor a ser pago pelo leito Privativo é de R$ 215,80", idade);
                                    }
                                    else if (idade >= 44 && idade <= 48)
                                    {
                                        Console.WriteLine("\n Pela idade {0} o valor a ser pago pelo leito Privativo é de R$ 266,35", idade);
                                    }
                                    else if (idade >= 49 && idade <= 53)
                                    {
                                        Console.WriteLine("\n Pela idade {0} o valor a ser pago pelo leito Privativo é de R$ 316,80", idade);
                                    }
                                    else if (idade >= 54 && idade <= 58)
                                    {
                                        Console.WriteLine("\n Pela idade {0} o valor a ser pago pelo leito Privativo é de R$ 417,70", idade);
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n Pela idade {0} o valor a ser pago pelo leito Privativo é de R$ 518,65", idade);
                                    }
                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("\n Comando pressionado inexistente");
                                }
                                break;
                        }    

                    }
                    break;

                case ConsoleKey.F3:
                    {
                        //Escreva um programa de computador para ler o percurso em quilômetros, o tipo de carro e informar o consumo estimado de combustível.
                        //Um carro do tipo A faz 12 Km com um litro de gasolina, um carro do tipo B faz 9 e um carro do tipo C faz 7 km por litro.


                        double percurso;

                        ConsoleKeyInfo lerTecla;
                        

                        Console.Clear();
                        Console.WriteLine(" -------------------------");
                        Console.WriteLine("|   F3   | Carro          |");
                        Console.WriteLine(" -------------------------");

                        Console.Write("Informe o tipo de carro que deseja (A, B ou C)? ");
                        lerTecla = Console.ReadKey();

                        Console.Write("\n Informe o percurso em km: ");
                        percurso = Convert.ToDouble(Console.ReadLine());

                        switch(lerTecla.Key)
                        {
                            case ConsoleKey.A:
                                {
                                    Console.WriteLine("O carro A faz o percurso de {0} km com o consumo estimado de {1} litros de combustivel", percurso, percurso/12);
                                }
                                break;
                            case ConsoleKey.B:
                                {
                                    Console.WriteLine("O carro B faz o percurso de {0} km com o consumo estimado de {1} litros de combustivel", percurso, percurso / 9);
                                }
                                break;
                            case ConsoleKey.C:
                                {
                                    Console.WriteLine("O carro C faz o percurso de {0} km com o consumo estimado de {1} litros de combustivel", percurso, percurso / 7);
                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("\n Comando pressionado inexistente");
                                }
                                break;
                        }
                        break;

                    }
                    break;

                case ConsoleKey.F4: 
                    {
                        //Crie um algoritmo que, dados o tamanho de três lados informados pelo usuário, verifique se: (1) é um triângulo isósceles, (2) é equilátero, (3) é escaleno ou(4) não é um triângulo.

                        int numero1, numero2, numero3;

                        Console.Clear();
                        Console.WriteLine(" -------------------------");
                        Console.WriteLine("|   F4   | Triângulo      |");
                        Console.WriteLine(" -------------------------");

                        Console.Write("Informe o 1º lado do triângulo: ");
                        numero1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Informe o 2º lado do triângulo: ");
                        numero2 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Informe o 3º lado do triângulo: ");
                        numero3 = Convert.ToInt32(Console.ReadLine());

                        if (numero1 >= (numero2 + numero3) || numero2 >= (numero1 + numero3) || numero3 >= (numero1 + numero2) || numero1 <= 0 || numero2 <= 0 || numero3 <= 0)
                        {
                            Console.WriteLine("Não forma um triângulo");
                        }

                        else if (numero1 == numero2 && numero2 == numero3)
                        {
                            Console.WriteLine("Triângulo equilátero!");
                        }
                        else if (numero1 == numero2 || numero1 == numero3 || numero2 == numero3)
                        {
                            Console.WriteLine("Triângulo isósceles!");
                        }
                        else
                        {
                            Console.WriteLine("Triângulo escaleno");
                        }

                    }
                    break;

                case ConsoleKey.F5:
                    {
                        //Faça um algoritmo que, dado o valor total em reais e o número de prestações desejadas, calcule o valor de cada prestação.
                        //O número mínimo de prestações deve ser 12. Se o número de prestações for maior ou igual a 24, adicione 10% de juros ao valor total, se for maior ou igual a 36, adicione 15% de juros ao valor total.

                        int parcelas;
                        double valor;

                        Console.Clear();
                        Console.WriteLine(" -------------------------");
                        Console.WriteLine("|   F5   | Prestação      |");
                        Console.WriteLine(" -------------------------");

                        Console.Write("Informe o valor total do emprestimo: ");
                        valor = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Informe o número de prestações: ");
                        parcelas = Convert.ToInt32(Console.ReadLine());

                        if (parcelas >= 12 && parcelas < 24)
                        {
                            Console.WriteLine("O emprestimo de {0} reais terá prestações de {1} ", valor, valor/parcelas);
                        }
                        else if (parcelas >=24 && parcelas < 36)
                        {
                            Console.WriteLine("O emprestimo de {0} reais terá como valor final {1} reais e prestações de {2} reais ", valor, valor * 1.10, (valor * 1.10)/parcelas);
                        }
                        else if (parcelas >= 36)
                        {
                            Console.WriteLine("O emprestimo de {0} reais terá como valor final {1} reais e prestações de {2} reais ", valor, valor * 1.15, (valor * 1.15) / parcelas);
                        }
                        else
                        {
                            Console.WriteLine("Número mínimo de parcelas insuficiente para solicitar empréstimo");
                        }

                    }
                    break;

                case ConsoleKey.F6:
                    {
                        //Desenvolva um programa, utilizando ternário, que leia o salário de um trabalhador e o valor da prestação de um empréstimo.
                        //Se a prestação for maior que 20% do salário imprima: Empréstimo não concedido, caso contrário imprima: Empréstimo concedido.

                        double salario, parcela;

                        Console.Clear();
                        Console.WriteLine(" -----------------------------");
                        Console.WriteLine("|   F6   | SalárioxEmpréstimo |");
                        Console.WriteLine(" -----------------------------");

                        Console.Write("Informe o seu salario: ");
                        salario = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Informe o valor da prestação do empréstimo: ");
                        parcela = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(parcela > salario * 0.20 ? "Empréstimo não concedido" : "Empréstimo concedido");

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
