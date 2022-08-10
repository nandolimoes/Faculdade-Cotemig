using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LerTecla
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleKeyInfo lerTecla;

            

            
            // o teclado é um endereço, linhas e colunas. 

            Console.Write("Presione uma tecla: ");

            lerTecla = Console.ReadKey();

            Console.WriteLine(" --------------------------");
            Console.WriteLine("| TECLA | Exercicio        |");
            Console.WriteLine(" --------------------------");
            Console.WriteLine("|  F1 | Calculo Fatorial   |");
            Console.WriteLine(" --------------------------");
            Console.WriteLine("|  F2 | Calculo IMC        |");
            Console.WriteLine(" --------------------------");
            Console.WriteLine("|  F3 | Moda               |");
            Console.WriteLine(" --------------------------");
            Console.WriteLine("| ESC | Sair do Sistema    |");
            Console.WriteLine(" --------------------------");



            Console.WriteLine("\n VocÊ pressionou a tecla {0}", lerTecla.Key);

            switch (lerTecla.Key)
            {
                case ConsoleKey.F1:
                    {
                        Console.Clear();
                        Console.WriteLine(" --------------------------");
                        Console.WriteLine("|  F1 | Calculo Fatorial   |");
                        Console.WriteLine(" --------------------------");
                    }
                    break;
                case ConsoleKey.F2:
                    {
                        Console.Clear();
                        Console.WriteLine(" --------------------------");
                        Console.WriteLine("|  F2 | Calculo IMC        |");
                        Console.WriteLine(" --------------------------");
                    }
                    break;
                case ConsoleKey.F3:
                    {
                        Console.Clear();
                        Console.WriteLine(" --------------------------");
                        Console.WriteLine("|  F3 | Moda               |");
                        Console.WriteLine(" --------------------------");
                    }
                    break;
                case ConsoleKey.Escape:
                    {
                        Console.Clear();
                        Console.WriteLine(" --------------------------");
                        Console.WriteLine("| ESC | Sair do Sistema    |");
                        Console.WriteLine(" --------------------------");
                    }
                    break; 
            }
            
            Console.ReadKey();


        }
    }
}
