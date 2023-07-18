using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("*******************************************");
            Console.WriteLine(" Suma de los numeros impares del 1 al 100");
            Console.WriteLine("*******************************************");
            Console.WriteLine();
            int numero = 0;
            int suma = 0;

            while (numero < 100)
            {
                numero++;
                if (numero % 2 == 1)
                {
                    suma += numero;
                    
                }
            }

            Console.WriteLine($" Suma de los numero impares {suma }");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
