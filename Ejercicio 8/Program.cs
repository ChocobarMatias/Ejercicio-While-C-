using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Numeros pares entre dos numeros - while");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int num1 = 0;
            int num2 = 0;
            Console.Write("Ingresar el primero numero entero = ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Ingresar el segundo numero entero = ");
            num2 = Int32.Parse(Console.ReadLine());
            while (num2 > num1)
            {
                num1++;
                
                    if (num1 % 2 == 0)
                    {
                    Console.WriteLine();
                        Console.WriteLine("  ."+num1);
                    }
                
            }
            Console.WriteLine();
            Console.WriteLine("******************");
            Console.WriteLine("| Fin del Proceso |");
            Console.WriteLine("******************");
            Console.ReadKey();

        }
    }
}
