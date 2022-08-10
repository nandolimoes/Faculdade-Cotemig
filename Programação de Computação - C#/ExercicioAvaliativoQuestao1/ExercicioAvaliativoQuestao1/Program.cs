using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAvaliativoQuestao1
{
    class Program
    {
        /*Para donos de carros bicombustíveis, o álcool é mais vantajoso economicamente se o preço não ultrapassar
70% do preço da gasolina.Escreva um programa em C# que indique ao motorista qual combustível o mesmo
deve utilizar.*/

        static void Main(string[] args)
        {
            double gasolina, alcool;

            Console.Write("Informe o valor da gasolina: ");
            gasolina = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o valor do alcool: ");
            alcool = Convert.ToDouble(Console.ReadLine());

            if (alcool / gasolina <= 0.70)
            {
                Console.WriteLine("Com o valor do alcool a {0} e da gasolina a {1} recomenda-se a utilização do alcool!", alcool, gasolina);
            }
            else
            {
                Console.WriteLine("Com o valor do alcool a {0} e da gasolina a {1} recomenda-se a utilização da gasolina!", alcool, gasolina);
            }
            Console.ReadKey(); 
         


        }
    }
}
