using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Op.Relacionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2; // declaração dos números a comparar

            Console.Write("Entre com o primeiro número inteiro: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entre com o segundo número inteiro: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 < numero2)
                Console.WriteLine("{0} < {1}", numero1, numero2);

            if (numero1 > numero2)
                Console.WriteLine("{0} > {1}", numero1, numero2);

            if (numero1 <= numero2)
                Console.WriteLine("{0} <= {1}", numero1, numero2);

            if (numero1 >= numero2)
                Console.WriteLine("{0} >= {1}", numero1, numero2);

            if (numero1 == numero2)
                Console.WriteLine("{0} == {1}", numero1, numero2);

            if (numero1 != numero2)
                Console.WriteLine("{0} != {1}", numero1, numero2);

            Console.ReadKey();
        }
    }
}
