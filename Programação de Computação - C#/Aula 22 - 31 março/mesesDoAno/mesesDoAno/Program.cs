using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesesDoAno
{
    class Program
    {
        static void Main(string[] args)
        {

            int menu;

            Console.WriteLine("CÓDIGO | PROGRAMA");
            Console.WriteLine("  1    | Meses    ");
            Console.WriteLine("  2    | Loja    ");
            Console.WriteLine("  3    | Operações");
            Console.WriteLine("  4    | Cardápio    ");
            Console.WriteLine("  5    | Calculadora    ");
            Console.WriteLine("  6    | Conceito Aluno    ");

  
            Console.Write("Informe o exercicio a ser executado: ");
            menu = Convert.ToInt32(Console.ReadLine());

            
            switch (menu)
            {
              case 1:
                    {
                        Console.Clear();
                        Console.WriteLine(" ------------------------");
                        Console.WriteLine("|   INÍCIO DO PROGRAMA   |");
                        Console.WriteLine(" ------------------------");



                        //Escreva um programa utilizando o comando switch que imprima um mês de acordo com o número digitado pelo usuário.
                        //Caso o usuário informe um número não correspondente informe que o mês é inexistente.

                        int mes;

                        Console.WriteLine(" ------------------------");
                        Console.WriteLine("|CÓDIGO |       MÊS     |");
                        Console.WriteLine("|   1   |   JANEIRO     |");
                        Console.WriteLine("|   2   |   FEVEREIRO   |");
                        Console.WriteLine("|   3   |   MARÇO       |");
                        Console.WriteLine("|   4   |   ABRIL       |");
                        Console.WriteLine("|   5   |   MAIO        |");
                        Console.WriteLine("|   6   |   JUNHO       |");
                        Console.WriteLine("|   7   |   JULHO       |");
                        Console.WriteLine("|   8   |   AGOSTO      |");
                        Console.WriteLine("|   9   |   SETEMBRO    |");
                        Console.WriteLine("|  10   |   OUTUBRO     |");
                        Console.WriteLine("|  11   |   NOVEMBRO    |");
                        Console.WriteLine("|  12   |   DEZEMBRO    |");
                        Console.WriteLine(" ------------------------");

                        Console.Write("Digite o código do mês desejado: ");
                        mes = Convert.ToInt32(Console.ReadLine());

                        switch (mes)
                        {
                            case 1:
                                {

                                    Console.WriteLine("Mês informado Janeiro");
                                    break;
                                }
                            case 2:
                                {

                                    Console.WriteLine("Mês informado Fevereiro");
                                    break;
                                }
                            case 3:
                                {

                                    Console.WriteLine("Mês informado Março");
                                    break;
                                }
                            case 4:
                                {

                                    Console.WriteLine("Mês informado Abril");
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("Mês informado Maio");
                                    break;
                                }
                            case 6:
                                {

                                    Console.WriteLine("Mês informado Junho");
                                    break;
                                }
                            case 7:
                                {

                                    Console.WriteLine("Mês informado Julho");
                                    break;
                                }
                            case 8:
                                {
 
                                    Console.WriteLine("Mês informado Agosto");
                                    break;
                                }
                            case 9:
                                {
 
                                    Console.WriteLine("Mês informado Setembro");
                                    break;

                                }
                            case 10:
                                {

                                    Console.WriteLine("Mês informado Outubro");
                                    break;
                                }
                            case 11:
                                {

                                    Console.WriteLine("Mês informado Novembro");
                                    break;
                                }
                            case 12:
                                {

                                    Console.WriteLine("Mês informado Dezembro");
                                    break;
                                }
                            default:
                                {

                                    Console.WriteLine("Mês inexistente");
                                    break;
                                }
                        }
                        Console.WriteLine(" ------------------------");
                        Console.WriteLine("|     FIM DO PROGRAMA    |");
                        Console.WriteLine(" ------------------------");
                        break;
                      
                    }
                    case 2:
                    {

                        Console.Clear();
                        Console.WriteLine(" ------------------------");
                        Console.WriteLine("|   INÍCIO DO PROGRAMA   |");
                        Console.WriteLine(" ------------------------");

                        //Uma loja fornece 10% de desconto para funcionários e 5% de desconto para clientes vips. Faça um programa que calcule o valor total a ser pago por uma pessoa.
                        //O programa deverá ler o valor total da compra efetuada e um código que identifique se o comprador é um cliente comum (1), funcionário (2) ou vip (3).
                        //Apresente o valor a ser pago pelo cliente.

                        double compra;
                        int cod;

                        Console.WriteLine("--------------------------");
                        Console.WriteLine("| Código | Identificação |");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("|   1    | Cliente Comum |");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("|   2    | Funcionário   |");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("|   3    | Cliente VIP   |");
                        Console.WriteLine("--------------------------");

                        Console.Write("Informe o Código correpondente ao comprador: ");
                        cod = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Informe o valor da compra: ");
                        compra = Convert.ToDouble(Console.ReadLine());

                        switch (cod)
                        {
                            case 1:
                                {
 
                                    Console.WriteLine("O valor a ser pago pelo comprador de acordo com o código informado é de {0}", compra);

                                }
                                break;

                            case 2:
                                {

                                    Console.WriteLine("O valor a ser pago pelo comprador de acordo com o código informado é de {0}", compra * 0.90);

                                }
                                break;

                            case 3:
                                {

                                    Console.WriteLine("O valor a ser pago pelo comprador de acordo com o código informado é de {0}", compra * 0.95);

                                }
                                break;

                            default:
                                {
                                    Console.WriteLine("Codigo informado inexistente");

                                }
                                break;
                        }
                        Console.WriteLine(" ------------------------");
                        Console.WriteLine("|     FIM DO PROGRAMA    |");
                        Console.WriteLine(" ------------------------");
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine(" ------------------------");
                        Console.WriteLine("|   INÍCIO DO PROGRAMA   |");
                        Console.WriteLine(" ------------------------");

                        //Faça um programa que receba dois números e execute as operações listadas a seguir de acordo com o número da escolha do usuário:

                        double num1, num2;
                        int usuario;

                        
                        Console.WriteLine(" ---------------------");
                        Console.WriteLine("|  CÓDIGO | OPERAÇÃO  |");
                        Console.WriteLine("|    1    | MÉDIA     |");
                        Console.WriteLine("|    2    | DIFERENÇA |");
                        Console.WriteLine("|    3    | PRODUTO   |");
                        Console.WriteLine("|    4    | DIVISÃO   |");
                        Console.WriteLine(" ---------------------");
                        Console.Write("Informe a operação desejada:");
                        usuario = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Informe o primeiro número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Informe o segundo número: ");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        switch (usuario)
                        {
                            case 1:
                                {

                                    Console.WriteLine("OPERAÇÃO ESCOLHIDA: MÉDIA");
                                    Console.WriteLine("A média do número {0} e o número {1} é igual a {2}", num1, num2, (num1+num2)/2);
                                }
                                break;
                            case 2:
                                {
 
                                    Console.WriteLine("OPERAÇÃO ESCOLHIDA: DIFERENÇA");
                                    Console.WriteLine("A diferença do número {0} e o número {1} é igual a {2}", num1, num2, (num1 - num2));
                                }
                                break;
                            case 3:
                                {
 
                                    Console.WriteLine("OPERAÇÃO ESCOLHIDA: PRODUTO");
                                    Console.WriteLine("O produto do número {0} e o número {1} é igual a {2}", num1, num2, (num1 * num2));
                                }
                                break;
                            case 4:
                                {

                                    Console.WriteLine("OPERAÇÃO ESCOLHIDA: DIVISÃO");
                                    Console.WriteLine("A divisão do número {0} e o número {1} é igual a {2}", num1, num2, (num1/num2));
                                }
                                break;

                        }



                        Console.WriteLine(" ------------------------");
                        Console.WriteLine("|     FIM DO PROGRAMA    |");
                        Console.WriteLine(" ------------------------");
                        break;
                    }
             
            }
            Console.ReadKey();
        }
    }
}


                   
                
