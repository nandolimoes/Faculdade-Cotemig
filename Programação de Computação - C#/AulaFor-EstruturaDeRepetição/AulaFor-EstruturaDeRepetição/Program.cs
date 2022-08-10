using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaFor_EstruturaDeRepetição
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo lerTecla;

            Console.WriteLine("----------------------");
            Console.WriteLine("| F1 | Contador       |");
            Console.WriteLine("----------------------");
            Console.WriteLine("| F2 | Tabuada        |");
            Console.WriteLine("----------------------");
            Console.WriteLine("| F3 | Número Random  |");
            Console.WriteLine("----------------------");
            Console.WriteLine("| F4 | Loteria        |");
            Console.WriteLine("----------------------");

            Console.WriteLine("Informe o exercício: ");
            lerTecla = Console.ReadKey();

            switch (lerTecla.Key)
            {
                case ConsoleKey.F1:

                    Console.Clear();
                    Console.WriteLine("----------------------");
                    Console.WriteLine("| F1 | Contador       |");
                    Console.WriteLine("----------------------\n");

                    // for (inicialização;condição;incre/decre)

                    for (int cont = 1; cont <= 10; cont++)
                    {
                        Console.WriteLine("Numero {0}", cont);
                        //  cont += 3;
                    }

                    for (int cont = 10; cont >= 1; cont--)
                    {
                        Console.WriteLine("Numero {0}", cont);
                    }

                    break;

               
                case ConsoleKey.F2:
                    {
                        Console.Clear();
                        Console.WriteLine("----------------------");
                        Console.WriteLine("| F2 | Tabuada        |");
                        Console.WriteLine("----------------------\n");

                        int numero;
                        Console.Write("Informe um numero: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i <= 10; i++)
                        {
                            Console.WriteLine("{0} x {1} = {2}", numero, i, numero*i) ;
                        }

                    }
                    break;

                case ConsoleKey.F3:
                    {

                        Random numeroRandom = new Random();

                        int numero;

                        Console.Clear();
                        Console.WriteLine("----------------------");
                        Console.WriteLine("| F3 | Número Random  |");
                        Console.WriteLine("----------------------\n");

                        for (int i = 0; i <= 10; i++)
                        {
                            numero = numeroRandom.Next();

                            Console.WriteLine("{0}º numero: {1}" ,i , numero);
                        }
                    }
                    break;

                case ConsoleKey.F4:
                    {
                        Random numeroRandom = new Random();

                        Console.Clear();
                        Console.WriteLine("----------------------");
                        Console.WriteLine("| F4 | Loteria        |");
                        Console.WriteLine("----------------------\n");

                        for (int i = 1; i <= 6; i++)
                        {
                            Console.WriteLine("{0}º número sorteado foi: {1}", i, numeroRandom.Next(1,61));
                        }
                    }
                    break;

            }

            Console.ReadKey();
        }
    }
}
