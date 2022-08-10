using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_Condicional_IF_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            // condicional sempre busca verdade - if existe sem else mas else nao existe sem if

            Console.Write("Informe o primeiro número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("O número {0} é o maior número", numero1);
            }
            else
            {
                Console.WriteLine("O número {0} é o maior número", numero2);
            }
         

            Console.ReadKey();
        }
    }
}
