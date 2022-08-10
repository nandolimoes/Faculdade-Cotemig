using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo;


            Console.WriteLine(" -------------------------------");
            Console.WriteLine("| COD | Exercício               |");
            Console.WriteLine("|  1  | Soma de valores         |");
            Console.WriteLine("|  2  | Casada, tempo casada    |");
            Console.WriteLine("|  3  | Ímpar ou par            |");
            Console.WriteLine("|  4  | A e B maior que C ?     |");
            Console.WriteLine("|  5  | Positivo ou negativo ?  |");
            Console.WriteLine("|  6  | Verdadeiros ou falsos ? |");
            Console.WriteLine("|  7  | Par + 5 ou Ímpar + 8 ?  |");
            Console.WriteLine(" -------------------------------");

            Console.WriteLine("Informe o código: ");

            codigo = Convert.ToInt32(Console.ReadLine());

            switch (codigo)
            {

                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine(" -------------------------------");
                        Console.WriteLine("|  1  | Soma de valores         |");
                        Console.WriteLine(" -------------------------------");
                        double A, B, C, soma;
                        string resultado;
                        Console.Write("Informe o valor do número A: ");
                        A = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Informe o valor do número B: ");
                        B = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Informe o valor do número C: ");
                        C = Convert.ToDouble(Console.ReadLine());
                        soma = A + B;
                        Console.WriteLine("O valor da soma de A+B é {0}", soma > C ? "maior que C" : "menor que C");
                    }
                    break;
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine(" -------------------------------");
                        Console.WriteLine("|  2  | Casada, tempo casada    |");
                        Console.WriteLine(" -------------------------------");
                        Console.WriteLine("Não consegui fazer");  
                    }
                    break;
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine(" -------------------------------");
                        Console.WriteLine("|  3  | Ímpar ou par            |");
                        Console.WriteLine(" -------------------------------");
                        double numero;
                        Console.Write("Informe um número: ");
                        numero = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("O número é {0}", numero % 2 == 0 ? "par" :
                        "ímpar");
                    }
                    break;
                case 4:
                    {
                        Console.Clear();
                        Console.WriteLine(" -------------------------------");
                        Console.WriteLine("|  4  | A e B maior que C ?     |");
                        Console.WriteLine(" -------------------------------");
                        int A, B, C;
                        Console.Write("Informe o valor do 1º número: ");
                        A = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Informe o valor do 2º número: ");
                        B = Convert.ToInt32(Console.ReadLine());
                        C = A == B ? A + B : A * B;
                        Console.WriteLine(C);
                    }
                    break;
                case 5:
                    {
                        Console.Clear();
                        Console.WriteLine(" -------------------------------");
                        Console.WriteLine("|  5  | Positivo ou negativo ?  |");
                        Console.WriteLine(" -------------------------------");
                        double numero;
                        Console.Write("Informe 1 número: ");
                        numero = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Resultado para o número informado {0} ", numero >
                        0 ? Math.Pow(numero, 2) : Math.Pow(numero, 3));
                    }
                    break;
                case 6:
                    {
                        Console.Clear();
                        Console.WriteLine(" -------------------------------");
                        Console.WriteLine("|  6  | Verdadeiros ou falsos ? |");
                        Console.WriteLine(" -------------------------------");
                        bool valor1, valor2;
                        Console.Write("Informe se o primeiro valor é true ou false: ");
                        valor1 = Convert.ToBoolean(Console.ReadLine());
                        Console.Write("Informe se o segundo valor é true ou false: ");
                        valor2 = Convert.ToBoolean(Console.ReadLine());
                        if (valor1 == valor2)
                        {
                            Console.Write("{0}", valor1 == true ? "Ambos são verdadeiros!" : "Ambos são falsos!");
                        }
                        else
                        {
                            Console.Write("Um valor é verdadeiro e o outro é falso");
                        }
                    }
                    break;
                case 7:
                    {
                        Console.Clear();
                        Console.WriteLine(" -------------------------------");
                        Console.WriteLine("|  7  | Par + 5 ou Ímpar + 8 ?  |");
                        Console.WriteLine(" -------------------------------");
                        double var;
                        Console.Write("Informe um número: ");
                        var = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("{0}", var % 2 == 0 ? var + 5 : var + 8);
                        Console.ReadKey();
                    }
                    break;
            }

            Console.WriteLine(" -------------------------------");
            Console.WriteLine("|      FIM DO PROGRAMA          |");
            Console.WriteLine(" -------------------------------");



            Console.ReadKey();


        }
    }
}
