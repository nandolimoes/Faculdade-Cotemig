using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo;

            Console.WriteLine(" -------------------------- ");
            Console.WriteLine("|   1   | Laranja          |");
            Console.WriteLine(" -------------------------- ");
            Console.WriteLine("|   2   | Limão            |");
            Console.WriteLine(" -------------------------- ");
            Console.WriteLine("|   3   | Manga            |");
            Console.WriteLine(" -------------------------- ");

            Console.WriteLine("Informe um código: ");

            codigo = Convert.ToInt32(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    {
                        Console.WriteLine("Laranja");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Limão");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Manga");
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Fruta Inexistente");
                    }
                    break;
            }

           /* if (codigo == 1)
            {
                Console.WriteLine("Laranja");
            }
            else if (codigo == 2)
            {
                Console.WriteLine("Limão");
            }
            else if (codigo == 3)
            {
                Console.WriteLine("Manga");
            }
            else
            {
                Console.WriteLine("Fruta Inexistente");
            }*/




            Console.ReadKey();


        }
    }
}
