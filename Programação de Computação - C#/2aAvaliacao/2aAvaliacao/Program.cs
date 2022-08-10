using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2aAvaliacao
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
                Console.WriteLine(" -----------------------------");
                Console.WriteLine("| COD  | Exercício            | ");
                Console.WriteLine("------------------------------");
                Console.WriteLine("|  F1  | Positivo e Negativo  | ");
                Console.WriteLine("------------------------------");
                Console.WriteLine("|  F2  | Fatorial             | ");
                Console.WriteLine("------------------------------");
                Console.WriteLine("|  F3  | Números Primos       | ");
                Console.WriteLine("------------------------------");
                Console.WriteLine("| ESC  |  SAIR                | ");
                Console.WriteLine("------------------------------");

                Console.Write("Digite a opção do exercício desejado: ");
                lerTecla = Console.ReadKey();

                if (lerTecla.Key == ConsoleKey.F1 || lerTecla.Key == ConsoleKey.F2
                    || lerTecla.Key == ConsoleKey.F3 || lerTecla.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("comendo correto");
                    Console.ReadLine();
                }
                else
                {
                    continua = false;
                    Console.WriteLine("\n Opção errada: Escolha uma das opções acima \n");
                    Console.ReadKey();
                }

            } while (continua);

            switch (lerTecla.Key)
            {
                case ConsoleKey.F1:
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("|  F1  | Positivo e Negativo  | ");
                        Console.WriteLine("------------------------------\n");

                        double numero, somaPosit = 0, somaNegat = 0;
                        int contPosit = 0, contNegat = 0;

                        Console.WriteLine("Contador e somatorio de números, utilize o 0 para parar quando quiser.");
                        Console.Write("Insira um número positivo ou negativo qualquer: ");
                        numero = Convert.ToDouble(Console.ReadLine());
                       
                       while (numero != 0)
                        {
                            if (numero > 0)
                            {
                                contPosit++;
                                somaPosit += numero;
                            }
                            else
                            {
                                contNegat++;
                                somaNegat += numero;
                            }

                            Console.Write("Insira um número positivo ou negativo qualquer: ");
                            numero = Convert.ToDouble(Console.ReadLine());

                        }

                        Console.WriteLine("Foram contabilizados {0} números positivos e a soma de todos eles é igual a {1}", contPosit++, somaPosit);
                        Console.WriteLine("Foram contabilizados {0} números negativos e a soma de todos eles é igual a {1}", contNegat++, somaNegat);

                    }
                    break;

                case ConsoleKey.F2:
                    {                  
                        Console.Clear();
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("|  F2  | Fatorial             | ");
                        Console.WriteLine("------------------------------\n");

                        int numero, fatorial;

                        Console.Write("Informe o número natural desejado: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        fatorial = numero;

                        for (int i = numero - 1; i >= 1; i--)
                        {
                            fatorial = fatorial * i;
                            Console.WriteLine("{0} x {1} = {2}", i, numero, i*numero);
                        }
                        Console.WriteLine("A soma do fatorial de {0} é igual a {1}", numero, fatorial);
                        
                    }
                    break;

           
                    case ConsoleKey.F3:
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("|  F3  | Números Primos       | ");
                        Console.WriteLine("------------------------------\n");

                        int numero, contmod = 0;

                        Console.Write("Digite um número: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        for (int i = 1; i <= numero; i++)
                        {
                            if (numero % i == 0)
                            {
                                contmod++;
                            }
                        }

                        if (contmod == 2)
                        {
                            Console.WriteLine("Número é primo");
                        }
                        else
                        {
                            Console.WriteLine("Número não é primo");
                        }
                    }
                    break;

                case ConsoleKey.Escape:
                    {

                        Console.WriteLine("\n------------------------------");
                        Console.WriteLine("| ESC  |  SAIR                | ");
                        Console.WriteLine("------------------------------");

                    }
                    break;
               
                    
            }

            Console.WriteLine("\n ------------------------------");
            Console.WriteLine("|       FIM DO PROGRAMA       | ");
            Console.WriteLine(" -----------------------------");
            Console.ReadKey();
        }   }       
}   

