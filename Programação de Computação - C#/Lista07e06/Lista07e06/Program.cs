using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista07e06
{
    class Program
    {
        //Escreva um algoritmo que lê dois valores booleanos(lógicos) e então determina se ambos são VERDADEIROS ou FALSOS.

        static void Main(string[] args)
        {
            bool x, y;

            Console.Write("Informe se X é true ou false: ");
            x = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Informe se Y é true ou false: ");
            y = Convert.ToBoolean(Console.ReadLine());

            if (x == y)

            {
                if (x == true)
                { 
                Console.WriteLine("Ambos são verdadeiros!");
                }
                else
                {
                    Console.WriteLine("Ambos são falsos!");
                }
            }
            else
            {
                Console.WriteLine("Um é Verdadeiro e o outro é falso!");
            }


            Console.ReadKey();
        }
    }
}
