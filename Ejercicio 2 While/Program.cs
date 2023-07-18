using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Muestra de los primero 1 numero inciando desde 100");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();

            int numeros = 100;
            //Inicio desde 100 el numero entero
            while (numeros >= 1)
            { 
                Console.WriteLine($"   . {numeros}");
// Uso el contador restando asi mismo un 1 acada vez hasta que se compla la condicion del Bucle While
            numeros--;
            }
            Console.WriteLine();
            Console.WriteLine("*****************");
            Console.WriteLine("|Fin del Proceso|");
            Console.WriteLine("*****************");
            Console.ReadKey();
        }
    }
}
