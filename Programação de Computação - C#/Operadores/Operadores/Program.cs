using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 3;

            c = c + 3;

            c += 3;

            c = c + 1;

            ++c; //4
            --c; //2

            c++;
            c--;

            int c;

            //Demonstração Utilizando o operador Pós-incremento

            c = 5; // atribui 5 a variável c

            Console.WriteLine(c); // imprime 5
            Console.WriteLine(c++); //imprime 5 e depois pós-incrementa
            Console.WriteLine(c); //imprime 6

            Console.WriteLine(); // pula uma linha

            //Demonstração utilizando o operador Pré-incremento

            c = 5; // atribui 5 a variável c

            Console.WriteLine(c); // imprime 5
            Console.WriteLine(++c); // pré-incrementa e depois imprime 6
            Console.WriteLine(c); // imprime 6

            Console.ReadKey();

        }
    }
}
