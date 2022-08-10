using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista06e01
{
    class Program
    {
        //Faça um programa que leia o valor de uma compra e a opção de pagamento(V – para pagamento à vista ou P – para pagamento parcelado (3x)).
        //Caso o cliente pague à vista terá um desconto de 5%, caso pague em 3 vezes terá um acréscimo de 8% do valor da compra.
        //O programa deve mostrar o valor da compra e o valor à vista ou valor a prazo(valor total e o valor de cada parcela)


        static void Main(string[] args)
        {
            double valorCompra;
            char opcaoPagamento;

            Console.Write("Valor da compra: ");
            valorCompra = Convert.ToDouble(Console.ReadLine());

            Console.Write("Opção de pagamento (V - pagamento à vista ou P - pagamento parcelado (3x)): ");
            opcaoPagamento = Convert.ToChar(Console.ReadLine());

            if (opcaoPagamento == 'V')
            {
                Console.WriteLine("O valor da compra foi de {0} com desconto a vista o valor passou a ser {1}",valorCompra, valorCompra - (valorCompra*0.05));
            }
            else
            {
                Console.WriteLine("O valor da compra foi de {0} com acréscimo para compras parceladas o novo valor passa a ser {1} e irá pagar 3 parcelas de {2}",valorCompra, valorCompra+(valorCompra*0.08), (valorCompra + (valorCompra * 0.08))/3);
            }

            Console.ReadKey();
        }
    }
}
