using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista08e05
{
    class Program
    {
        //Encontrar o dobro de um número caso ele seja positivo e o seu triplo caso seja negativo, imprimindo o resultado.
        static void Main(string[] args)
        {
            double numero;

            Console.Write("Informe 1 número: ");
            numero = Convert.ToDouble(Console.ReadLine());

            Console.Write("Resultado para o número informado {0} ", numero > 0 ? Math.Pow(numero,2): Math.Pow(numero, 3));

            Console.ReadKey();



        }
    }
}
