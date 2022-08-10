using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAvaliativo3
{
    class Program
    {
        /*Determinado comerciante precisa de um programa de computador para auxiliá-lo na etiquetação de preços.
Ele quer vender o produto com um lucro de 45% se o valor de compra for menor que R$ 20,00 ou então
30% de lucro para outros valores. O comerciante irá fornecer o nome do produto e seu valor de compra e o
programa vai gerar a etiqueta com o preço de venda.*/

        static void Main(string[] args)
        {
            string nome;
            double valorCompra;

            Console.Write("Informe o nome do produto: ");
            nome = Console.ReadLine();

            Console.Write("Informe o valor de compra do produto: ");
            valorCompra = Convert.ToDouble(Console.ReadLine());

            if (valorCompra < 20)
            {
                Console.WriteLine("O produto {0} deverá ser vendido por {1}", nome, valorCompra+(valorCompra*0.45));
            }
            else
            {
                Console.WriteLine("O produto {0} deverá ser vendido por {1}", nome, valorCompra + (valorCompra * 0.30));
            }

            Console.ReadKey();
        }
    }
}
