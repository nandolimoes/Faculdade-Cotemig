using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03e04
{

    /*Faça um programa que calcule a área total(m2) de uma casa com 4 cômodos.
     * O usuário deve inserir a largura e comprimento de cada um dos cômodos, calcular a área individual de cada um e por fim exibir a área total da casa.*/

    class Program
    {
        
        static void Main(string[] args)
        {

            double comodo1L, comodo1C, comodo2L, comodo2C, comodo3L, comodo3C, comodo4L, comodo4C, a1, a2, a3, a4, areaTotalCasa; //Largura, Comprimento, areaTotalCasa = 0;

            Console.Write("DIgite a largura do cômodo 1: ");
            comodo1L = Convert.ToDouble(Console.ReadLine()); //Largura
            Console.Write("Digite o comprimento do cômodo 1: ");
            comodo1C = Convert.ToDouble(Console.ReadLine()); //Comprimento
            a1 = comodo1L * comodo1C;
            // areaTotalCasa = areaTotalCasa + (Largura * Comprimento);

            Console.Write("DIgite a largura do cômodo 2: "); 
            comodo2L = Convert.ToDouble(Console.ReadLine()); //largura
            Console.Write("Digite o comprimento do cômodo 2: "); 
            comodo2C = Convert.ToDouble(Console.ReadLine()); //Comprimento
            a2 = comodo2L * comodo2C;
            // areaTotalCasa = areaTotalCasa + (Largura * Comprimento);

            Console.Write("DIgite a largura do cômodo 3: ");
            comodo3L = Convert.ToDouble(Console.ReadLine()); //largura
            Console.Write("Digite o comprimento do cômodo 3: "); 
            comodo3C = Convert.ToDouble(Console.ReadLine()); //Comprimento
            a3 = comodo3L * comodo3C;
            // areaTotalCasa = areaTotalCasa + (Largura * Comprimento);

            Console.Write("DIgite a largura do cômodo 4: "); 
            comodo4L = Convert.ToDouble(Console.ReadLine()); //largura
            Console.Write("Digite o comprimento do cômodo 4: "); 
            comodo4C = Convert.ToDouble(Console.ReadLine()); //Comprimento
            a4 = comodo4L * comodo4C;
            // areaTotalCasa = areaTotalCasa + (Largura * Comprimento);

            areaTotalCasa = a1 + a2 + a3 + a4;
            Console.WriteLine("O valor da área total da casa é igual a {0} m²", areaTotalCasa);

            Console.ReadKey();

        }
    }
}
