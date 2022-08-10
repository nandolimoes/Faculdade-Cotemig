using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista11
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo lerTecla;

            Random numeroRandom = new Random();

            Console.WriteLine("-------------------------------");
            Console.WriteLine("|  COD  | Exercício            |");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("|  F1  | Maior ou menor        |");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("|  F2  | Soma Par / Soma Ímpar |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|  F3  | Dividido por 11 resto 5|");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|  F4  | 100 primeiros ímpares  |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|  F5  | Sequência de números 11|");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|  F6  | Sequência de números 3 |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|  F7  | Tabuada de multiplicação|");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|  F8  | Sequência numérica     |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|  F9  | Conjunto de 3          |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|  F10 | Números primos e ñ primo|");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|  ESQ  | Sair do programa      |");
            Console.WriteLine("--------------------------------");

            //Escreva um programa em C# que lê 5 valores reais, encontra o maior e o menor deles e mostra o resultado.

            lerTecla = Console.ReadKey();

            switch (lerTecla.Key)
            {
                case ConsoleKey.F1:
                    {
                        double numero, maiorNumero, menorNumero;

                        Console.Clear();
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("|  F1  | Maior ou menor |");
                        Console.WriteLine("-----------------------");
                        Console.Write("Informe o 1º número: ");
                        numero = Convert.ToDouble(Console.ReadLine());

                        menorNumero = numero;
                        maiorNumero = numero;

                        for (int i = 2; i <= 5; i++)
                        {
                            Console.Write("Informe o {0}º número: ", i);
                            numero = Convert.ToDouble(Console.ReadLine());

                            if (numero > maiorNumero)
                            {
                                maiorNumero = numero;
                            }
                            if(numero < menorNumero)
                            {
                                menorNumero = numero;
                            }
                        }

                        Console.WriteLine("O menor numero encontrado foi: {0}", menorNumero);
                        Console.WriteLine("O maior numero encontrado foi: {0}", maiorNumero);



                    }
                    break;

                case ConsoleKey.F2:
                    {
                        //Faça um programa que leia 6 números inteiros positivos e mostre, no final, a soma dos números pares e a soma dos números ímpares.

                        int numero, somaPar = 0, somaImpar = 0;
                        Console.Clear();
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("|  F2  | Soma Par / Soma Ímpar |");
                        Console.WriteLine("--------------------------------");

                        for(int i = 1; i <= 6; i++)
                        {
                            Console.Write("Informe o {0}º número: ", i);
                            numero = Convert.ToInt32(Console.ReadLine());

                            if (numero % 2 == 0)
                            {
                                somaPar += numero;
                            }

                            else
                            {
                                somaImpar += numero;
                            }
                        }

                        Console.WriteLine("A soma dos números pares foi: {0} ", somaPar);
                        Console.WriteLine("A soma dos números ímpares foi: {0} ", somaImpar);

                    }
                        break;

                case ConsoleKey.F3:
                    {
                        //Escreva um programa em C# que gere números entre 1000 e 1999 e mostra aqueles que divididos por 11 dão resto 5.

                        int contmod = 0;

                        Console.Clear();
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("|  F3  | Dividido por 11 resto 5|");
                        Console.WriteLine("--------------------------------");

                        for (int i = 1000; i <= 1999; i++)
                        {
                            if (i % 11 == 5)
                            {
                                contmod++;
                                Console.WriteLine("O numero {0} / 11 tem resto 5", i);
                                
                            }
                        }
                        Console.WriteLine("Foram encontrados {0} numeros", contmod);
                    }
                    break;

                case ConsoleKey.F4:
                    {
                        //Escreva um programa em C# que imprima os 100 primeiros números ímpares.

                        int contmod = 0;

                        Console.Clear();
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("|  F4  | 100 primeiros ímpares  |");
                        Console.WriteLine("--------------------------------");

                        for (int i = 0; i <= 100; i++)
                        {
                            if (i % 2 != 0)
                            {
                                contmod++;
                                Console.WriteLine("Os primeiros 100 números ímpares são: {0}", i);
                            }
                        }
                        Console.WriteLine("Foram encontrados {0} números ímpares", contmod);
                    }
                    break;

                case ConsoleKey.F5:
                    {
                        //Escreva um programa que imprima a sequência dos valores: 99, 88, 77, 66, 55, 44, 33, 22, 11, 0. 3.

                        int contmod = 0;

                        Console.Clear();
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("|  F5  | Sequência de números 11|");
                        Console.WriteLine("--------------------------------");

                        for (int i = 0; i <= 99; i += 11)
                        {
                            contmod++;
                            Console.WriteLine("A sequência de números de 11 em 11 são: {0} ", i);
                        }
                        Console.WriteLine("E foram encontrados {0} números", contmod);
                    }
                        break;

                case ConsoleKey.F6:
                    {
                        //Escreva um programa que imprima a sequência dos valores: 2, 5, 8, 11, 14, 17, 20.

                        int contmod = 0;

                        Console.Clear();
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("|  F6  | Sequência de números 3 |");
                        Console.WriteLine("--------------------------------");

                        for (int i = 2; i <= 20; i += 3)
                        {
                            contmod++;
                            Console.WriteLine("A sequência de números de 3 em 3 são: {0} ", i);
                        }
                        Console.WriteLine("E foram encontrados {0} números", contmod);
                    }
                    break;

                case ConsoleKey.F7:
                    {
                        //Desenvolva um código que construa uma tabuada de multiplicação dos números de 1 a 10.

                        Console.Clear();
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("|  F7  | Tabuada de multiplicação|");
                        Console.WriteLine("---------------------------------");

                        
                        for (int i = 0; i <= 10; i++)
                        {
                            for (int j = 0; j <= 10; j++)
                            {
                                Console.WriteLine("A tabuada de multiplicação é: {0} x {1} = {2}", i, j, i*j);
                            }
                            
                        }
                    }
                    break;

                case ConsoleKey.F8:
                    {
                        //Construa um programa que gere a seguinte sequência numérica: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1.

                        Console.Clear();
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("|  F8  | Sequência numérica     |");
                        Console.WriteLine("--------------------------------");

                        for (int i = 1; i <=9; i++)
                        {
                          
                           Console.WriteLine("{0}", i);
               
                        }

                        for (int i = 10; i >= 1; i--)
                        {
                            Console.WriteLine("{0}", i);
                        }
                    }
                    break;

                case ConsoleKey.F9:
                    {
                        //Faça um programa que leia vários conjuntos de três valores reais e mostre para cada conjunto: sua soma, seu produto e sua média.
                        //O programa para quando um conjunto não entrar com seus valores em ordem crescente.

                        double numero1, numero2, numero3;

                        bool continua = true;

                        Console.Clear();
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("|  F9  | Conjunto de 3          |");
                        Console.WriteLine("--------------------------------");

                        for (int i = 0; continua; i++)
                        {
                          Console.WriteLine("\n|--------------|");
                            Console.WriteLine("|{0}º conjunto   |", i + 1);
                            Console.WriteLine("|--------------|\n");

                            Console.Write("Informe o 1º valor: ");
                            numero1 = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Informe o 2º valor: ");
                            numero2 = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Informe o 3º valor: ");
                            numero3 = Convert.ToDouble(Console.ReadLine());

                            if(numero1 < numero2 && numero2 < numero3)
                            {
                                Console.WriteLine("Soma: {0}", numero1 + numero2 + numero3);
                                Console.WriteLine("Produto: {0}", numero1 * numero2 * numero3);
                                Console.WriteLine("Média: {0}", Math.Round((numero1 + numero2 + numero3)/3),2);
                            }
                            else
                            {
                                continua = false;

                                Console.WriteLine("|--------------------------------|");
                                Console.WriteLine("|Números fora da ordem crescente!|");
                                Console.WriteLine("|--------------------------------|");
                                Console.WriteLine("|Foram digitados {0} conjuntos!    |", i);
                                Console.WriteLine("|--------------------------------|");
                            }
                        }
                    }
                    break;

                case ConsoleKey.F10:
                    {
                        //Faça um programa que leia um número n e imprima se ele é primo ou não.
                        //(um número primo tem apenas 2 divisores: 1 e ele mesmo! O número 1 não é primo!!!)

                        int numero, contmod = 0;

                        Console.Clear();
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("|  F10 | Números primos e ñ primo|");
                        Console.WriteLine("--------------------------------");

                        Console.Write("Digite um número: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        for (int i = 1; i <= numero; i++)
                        {
                            if (numero % i == 0)
                            {
                                contmod++;
                            }
                        }

                        if (contmod == 2)
                        {
                            Console.WriteLine("Número é primo");
                        }
                        else
                        {
                            Console.WriteLine("Número não é primo");
                        }
                    }
                    break;

                case ConsoleKey.Escape:
                    {
                        Console.Clear();
                    }
                    break;

                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Comando Inexistente");
                    }
                    break;
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine("|        Fim do programa         |");
            Console.WriteLine("---------------------------------");

            Console.ReadKey();

        }
        
    }
}
