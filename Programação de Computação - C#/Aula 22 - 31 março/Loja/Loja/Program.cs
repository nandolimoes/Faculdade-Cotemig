using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Program
    {
        //Uma loja fornece 10% de desconto para funcionários e 5% de desconto para clientes vips.
        //Faça um programa que calcule o valor total a ser pago por uma pessoa. O programa deverá ler o valor total da compra efetuada e um código que identifique se o comprador é um cliente comum (1), funcionário (2) ou vip (3).
        //Apresente o valor a ser pago pelo cliente.

        static void Main(string[] args)
        {
            double compra;
            int cod;

            Console.WriteLine("--------------------------");
            Console.WriteLine("| Código | Identificação |");
            Console.WriteLine("--------------------------");
            Console.WriteLine("|   1    | Cliente Comum |");
            Console.WriteLine("--------------------------");
            Console.WriteLine("|   2    | Funcionário   |");
            Console.WriteLine("--------------------------");
            Console.WriteLine("|   3    | Cliente VIP   |");
            Console.WriteLine("--------------------------");

            Console.Write("Informe o Código correpondente ao comprador: ");
            cod = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o valor da compra: ");
            compra = Convert.ToDouble(Console.ReadLine());

            switch(cod)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("O valor a ser pago pelo comprador de acordo com o código informado é de {0}", compra);
                        
                    }
                    break;

                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("O valor a ser pago pelo comprador de acordo com o código informado é de {0}", compra * 0.90);
                        
                    }
                    break;

                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("O valor a ser pago pelo comprador de acordo com o código informado é de {0}", compra * 0.95);
                        
                    }
                    break;

                default:
                    {
                    Console.WriteLine("Codigo informado inexistente");
                    
                    }
                    break;

            }
            Console.ReadKey();

        }
    }
}
