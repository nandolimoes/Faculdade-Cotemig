using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista09
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo lerTecla;

            Console.WriteLine("------------------------");
            Console.WriteLine("| TECLA   | PROGRAMA     |");
            Console.WriteLine("------------------------");
            Console.WriteLine("|   F1    | Meses        |");
            Console.WriteLine("------------------------");
            Console.WriteLine("|   F2    | Loja         |");
            Console.WriteLine("------------------------");
            Console.WriteLine("|   F3    | Operações    |");
            Console.WriteLine("------------------------");
            Console.WriteLine("|   F4    | Cardápio     |");
            Console.WriteLine("------------------------");
            Console.WriteLine("|   F5    | Calculadora  |");
            Console.WriteLine("------------------------");
            Console.WriteLine("|   F6    |Conceito Aluno|");
            Console.WriteLine(" -----------------------");
            Console.WriteLine("|  ESC    |Sair do sistema|");
            Console.WriteLine(" -------------------------");


            Console.Write("Aperte a tecla correspondente ao programa desejado: ");
            lerTecla = Console.ReadKey();




            switch (lerTecla.Key)
            {

                case ConsoleKey.F1:
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------");
                        Console.WriteLine("|   F1    | Meses        |");
                        Console.WriteLine("------------------------");



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
                        
                        break;

                    }

                case ConsoleKey.F2:
                    {

                        Console.Clear();
                        Console.WriteLine("------------------------");
                        Console.WriteLine("|   F2    | Loja         |");
                        Console.WriteLine("------------------------");

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
                        
                        break;
                    }

                case ConsoleKey.F3:
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------");
                        Console.WriteLine("|   F3    | Operações    |");
                        Console.WriteLine("------------------------");

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
                                    Console.WriteLine("A média do número {0} e o número {1} é igual a {2}", num1, num2, (num1 + num2) / 2);
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
                                    Console.WriteLine("A divisão do número {0} e o número {1} é igual a {2}", num1, num2, (num1 / num2));
                                }
                                break;

                        }



                        
                        break;
                    }

                case ConsoleKey.F4:
                    {

                        Console.Clear();
                        Console.WriteLine("------------------------");
                        Console.WriteLine("|   F4    | Cardápio     |");
                        Console.WriteLine("------------------------");

                        int cod, quantidade;
                        double valorPagar;

                        //O cardápio de uma casa de lanches é dado pela tabela abaixo:

                        Console.WriteLine("CÓDIGO | PRODUTO         | PREÇO UUNITÁRIO (R$)");
                        Console.WriteLine("100    | Cachorro Quente | R$ 1,70");
                        Console.WriteLine("101    | Bauru Simples   | R$ 2,30");
                        Console.WriteLine("102    | Bauru com ovo   | R$ 2,60");
                        Console.WriteLine("103    | Hamburguer      | R$ 2,40");
                        Console.WriteLine("104    | Cheeseburguer   | R$ 2,50");
                        Console.WriteLine("105    | Refrigerante    | R$ 1,00");

                        Console.Write("Informe o código do produto desejado: ");
                        cod = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Informe a quantidade de unidades do produto selecionado: ");
                        quantidade = Convert.ToInt32(Console.ReadLine());

                        switch (cod)
                        {
                            case 100:
                                {
                                    Console.WriteLine("o Valor a ser pago pelo Cachorro Quente é de {0} ", valorPagar = quantidade * 1.70);
                                }
                                break;
                            case 101:
                                {
                                    Console.WriteLine("o Valor a ser pago pelo Bauru Simples é de {0} ", valorPagar = quantidade * 2.30);
                                }
                                break;
                            case 102:
                                {
                                    Console.WriteLine("o Valor a ser pago pelo Bauru com ovo é de {0} ", valorPagar = quantidade * 2.60);
                                }
                                break;
                            case 103:
                                {
                                    Console.WriteLine("o Valor a ser pago pelo Hamburguer é de {0} ", valorPagar = quantidade * 2.40);
                                }
                                break;
                            case 104:
                                {
                                    Console.WriteLine("o Valor a ser pago pelo Cheeseburguer é de {0} ", valorPagar = quantidade * 1.70);
                                }
                                break;
                            case 105:
                                {
                                    Console.WriteLine("o Valor a ser pago pelo Refrigerante é de {0} ", valorPagar = quantidade * 1.70);
                                }
                                break;
                        }

                    }

                    
                    break;

                case ConsoleKey.F5:
                    {

                        Console.Clear();
                        Console.WriteLine("------------------------");
                        Console.WriteLine("|   F5    | Calculadora  |");
                        Console.WriteLine("------------------------");

                        //Faça um programa que simule uma calculadora básica, provendo a leitura de um valor, seguido da operação e do segundo valor (caso seja necessário).

                        int cod;
                        Double num1, num2;

                        Console.WriteLine(" -----------------------");
                        Console.WriteLine("| CÓDIGO | OPERAÇÃO     |");
                        Console.WriteLine("|    1   |     SOMA     |");
                        Console.WriteLine("|    2   |  SUBTRAÇÃO   |");
                        Console.WriteLine("|    3   | MULTIPLICAÇÃO|");
                        Console.WriteLine("|    4   |   DIVISÃO    |");
                        Console.WriteLine(" -----------------------");

                        Console.Write("Informe o código da operação desejada: ");
                        cod = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Informe o primeiro número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Informe o segundo número: ");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        switch (cod)
                        {
                            case 1:
                                {
                                    Console.WriteLine("A operação SOMA entre os número {0} + {1} é igual a {2}", num1, num2, num1 + num2);
                                }
                                break;

                            case 2:
                                {
                                    Console.WriteLine("A operação SUBTRAÇÃO entre os número {0} - {1} é igual a {2}", num1, num2, num1 - num2);
                                }
                                break;

                            case 3:
                                {
                                    Console.WriteLine("A operação MULTIPLICAÇÃO entre os número {0} X {1} é igual a {2}", num1, num2, num1 * num2);
                                }
                                break;

                            case 4:
                                {
                                    Console.WriteLine("A operação DIVISÃO entre os número {0} / {1} é igual a {2}", num1, num2, num1 / num2);
                                }
                                break;
                        }
                    }

                    break;

                case ConsoleKey.F6:
                    {
                        //Crie um programa que lê o conceito de um aluno na disciplina Programação de Computadores - PC e imprime seu significado, de acordo com a tabela abaixo.
                        //Caso seja informado um conceito inexistente, deve ser exibida uma mensagem de erro.

                        char cod;

                        Console.Clear();
                        Console.WriteLine("------------------------");
                        Console.WriteLine("|   F6    |Conceito Aluno|");
                        Console.WriteLine(" -----------------------");

                        Console.WriteLine(" ------------------------");
                        Console.WriteLine("| CONCEITO | SIGNIFICADO |");
                        Console.WriteLine("|    A     |  EXCELENTE  |");
                        Console.WriteLine("|    B     |    ÓTIMO    |");
                        Console.WriteLine("|    C     |     BOM     |");
                        Console.WriteLine("|    D     |   REGULAR   |");
                        Console.WriteLine("|    E     |    RUIM     |");
                        Console.WriteLine("|    F     |  REPROVADO  |");
                        Console.WriteLine(" -----------------------------------");

                        Console.Write("Informe o código relacionado ao conceito do aluno: ");
                        cod = Convert.ToChar(Console.ReadLine());

                        switch (cod)
                        {
                            case 'A':
                                {
                                    Console.WriteLine("O conceito do estudante é A ou EXCELENTE!");
                                }
                                break;
                            case 'B':
                                {
                                    Console.WriteLine("O conceito do estudante é B ou ÓTIMO!");
                                }
                                break;
                            case 'C':
                                {
                                    Console.WriteLine("O conceito do estudante é C ou BOM!");
                                }
                                break;
                            case 'D':
                                {
                                    Console.WriteLine("O conceito do estudante é D ou REGULAR!");
                                }
                                break;
                            case 'E':
                                {
                                    Console.WriteLine("O conceito do estudante é E ou RUIM!");
                                }
                                break;
                            case 'F':
                                {
                                    Console.WriteLine("O conceito do estudante é F ou REPROVADO!");
                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("ERRO ! CÓDIGO INEXISTENTE");
                                }
                                break;



                        }


                    }
                    break;
                case ConsoleKey.Escape:
                    {
                        Console.Clear();
                        Console.WriteLine(" ------------------------");
                        Console.WriteLine("|     FIM DO PROGRAMA    |");
                        Console.WriteLine(" ------------------------");
                    }
                    break;
            }

            Console.ReadKey();
        }
    }
}

