using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescobrirParEImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;

            Console.Write("Informe o 1º número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            if (numero1 % 2 == 0)
            {
                Console.WriteLine("Número Par!");
            }
            else
            {
                Console.WriteLine("Número Ímpar!");
            }
            Console.ReadKey();  

        }
    }
}
