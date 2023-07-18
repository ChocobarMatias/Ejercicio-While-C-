using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++");
            Console.WriteLine(" Numeros pares del 1 al 100");
            Console.WriteLine("+++++++++++++++++++++++++++");

            int numeros = 1;

            while (numeros <= 100 )
            {
                //Utilizo este metodo para ver la paridad de los numeros ingresados
                if( numeros % 2 == 1)
                {
                    Console.WriteLine($"  . { numeros}");
                    
                }
                //Coloco el contador fuera del if para que se acumule con while
                numeros++;
            }
            Console.WriteLine();
            Console.WriteLine(" *****************");
            Console.WriteLine(" |Fin del Proceso|");
            Console.WriteLine(" *****************");
            Console.ReadKey();
        }
    }
}
