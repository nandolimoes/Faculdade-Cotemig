using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAvaliativo2
{
    class Program
    {

        /*Escreva um programa para calcular e interpretar o IMC(Índice de Massa Corporal), que é dado a partir do
peso(em quilogramas) dividido pelo quadrado da altura(em metros). A interpretação do resultado, segundo
a Organização Mundial de Saúde usa um critério simples:
        tabela pdf*/

        static void Main(string[] args)
        {
            double peso, altura, imc;

            Console.Write("Informe o seu peso (em KG): ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe sua altura (em metros): ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = peso / Math.Pow(altura, 2);

            if (imc < 18.5)
            {
                Console.WriteLine("O IMC {0} é considerado pela Organização Mundial da Saúde como abaixo do peso.", imc);
            }
            else if (imc >= 18.5 && imc <= 25)
            {
                Console.WriteLine("O IMC {0} é considerado pela Organização Mundial da Saúde como no peso normal.", imc);
            }
            else if (imc > 25 && imc <= 30)
            {
                Console.WriteLine("O IMC {0} é considerado pela Organização Mundial da Saúde como acima do peso.", imc);
            }
            else
                    {
                Console.WriteLine("O IMC {0} é considerado pela Organização Mundial da Saúde como Obeso", imc);
            }
                   

            Console.ReadKey();

        }
    }
}
