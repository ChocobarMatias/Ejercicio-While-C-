using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" |Suma de los numeros del 1 al 100|");
            Console.WriteLine(" ++++++++++++++++++++++++++++++++++");

            int numeros = 0;
            int suma = 0;

            while (numeros < 100)
            {
                
                numeros++;
                suma = suma + numeros;
               
            }
            Console.WriteLine();
            Console.WriteLine(" ===================================");
            Console.WriteLine($" Suma de numeros del 1 al 100 = { suma}");
            Console.WriteLine(" ===================================");
            Console.ReadKey();
        }
    }
}
