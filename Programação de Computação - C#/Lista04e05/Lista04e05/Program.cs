using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista04e05
{
    class Program
    {

        /*Fazer um programa em C# que leia um número e informe a tabuada deste numero*/

        static void Main(string[] args)
        {
            double numero1, cont = 0;

            Console.Write("Informe um número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0} * {1} = {2}", numero1, cont, numero1 * cont++);
            Console.WriteLine("{0} * {1} = {2}", numero1, cont, numero1 * cont++);
            Console.WriteLine("{0} * {1} = {2}", numero1, cont, numero1 * cont++);
            Console.WriteLine("{0} * {1} = {2}", numero1, cont, numero1 * cont++);
            Console.WriteLine("{0} * {1} = {2}", numero1, cont, numero1 * cont++);
            Console.WriteLine("{0} * {1} = {2}", numero1, cont, numero1 * cont++);
            Console.WriteLine("{0} * {1} = {2}", numero1, cont, numero1 * cont++);
            Console.WriteLine("{0} * {1} = {2}", numero1, cont, numero1 * cont++);
            Console.WriteLine("{0} * {1} = {2}", numero1, cont, numero1 * cont++);
            Console.WriteLine("{0} * {1} = {2}", numero1, cont, numero1 * cont++);
            Console.WriteLine("{0} * {1} = {2}", numero1, cont, numero1 * cont++);

            Console.ReadKey();


        }
    }
}
