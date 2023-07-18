using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("| Muestra de los primeros 100 numeros enteros iniciando desde el 1 |");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int numeros = 1;
//Inicie la variable numero en 1 para que se el primer numero que muestre al entrar al Bucle While
            while (numeros <= 100)
            { //No olvidar las llaves { para que entre al Bucle
                Console.WriteLine($"     . {numeros}");
            // Utilizo el la variable numero como un contador dentro del Bucle While para que muestre
            // los numeros que va registrando antes de llegar a la condicion para llegar al 100
            numeros++; //contador ampliando en 1 cada vez
                }
            Console.WriteLine();
            Console.WriteLine(" *****************");
            Console.WriteLine(" |Fin del Proceso| ");
            Console.WriteLine(" *****************");
            Console.ReadKey();
        }
    }
}
