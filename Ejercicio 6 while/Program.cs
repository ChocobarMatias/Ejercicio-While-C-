using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Suma de numero > 0, al ingresar uno negativo finaliza");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("");
            int suma = 0;
            int numero = 0;
            Console.WriteLine( "Ingresar un numero ");
            numero = Int32.Parse(Console.ReadLine());
            while (numero > 0)
            {
                numero++;
                if (suma != 0)
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Ingresar un numero ");
                    numero = Int32.Parse(Console.ReadLine());

                    //suma += numero;

                }

                suma += numero;
            }
            Console.WriteLine("");
            Console.WriteLine($" La suma de los sumeros ingresados es : {suma} ");
            Console.ReadKey();
        }
    }
}
