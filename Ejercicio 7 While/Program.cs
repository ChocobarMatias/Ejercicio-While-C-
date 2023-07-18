using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(" ===========================================================================");
            Console.WriteLine(" | Programa de menu de opciones(Sumar, Restar, Multiplicar, Dividir, Salir) | ");
            Console.WriteLine(" ===========================================================================");
            Console.WriteLine();
            double num1 = 0;
            double num2 = 0;
            double suma = 0;
            double resta = 0;
            double multiplicacion = 0;
            double division = 0;
            int opcion = 0;
            int contador = 0;
            string continuar = "";
            string ingresoNuevo = "";
            while (continuar != "N" || continuar != "n")
            { 
            if (contador == 0)
                {
                    Console.WriteLine();
                    Console.Write("Ingresar  el primer numero entero = ");
                    num1 = Int32.Parse(Console.ReadLine());
                    Console.Write("Ingresar el segundo numero entero = ");
                    num2 = Int32.Parse(Console.ReadLine());
                }
                Console.Clear();
                Console.WriteLine(" -----------------------------------------");
                Console.WriteLine(" | Calculadora simple, elegir una opcion |");
                Console.WriteLine(" -----------------------------------------");
                Console.WriteLine(" | 1) Sumar                              |");
                Console.WriteLine(" | 2) Restar                             |");
                Console.WriteLine(" | 3) Multiplicar                        |");
                Console.WriteLine(" | 4) Dividir                            |");
                Console.WriteLine(" | 5) Salir                              |");
                Console.WriteLine(" -----------------------------------------");
                Console.WriteLine();
                Console.Write(" Opcion elegida = ");
                opcion = Int32.Parse(Console.ReadLine());
                //Console.Clear();
                // Console.ReadKey();
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("-------------");
                            Console.WriteLine(" +++ SUMA +++");
                            Console.WriteLine("-------------");
                            Console.WriteLine();
                            suma = num1 + num2;
                            Console.WriteLine($" Suma = {num1} + {num2} = {suma}");
                            contador++;
                            Console.WriteLine();
                            Console.Write(" Desea continuar? (S/N) : ");
                            continuar = Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("-------------");
                            Console.WriteLine(" +++ RESTA +++");
                            Console.WriteLine("-------------");
                            Console.WriteLine();
                            resta = num1 - num2;
                            Console.WriteLine($" Resta = {num1} - {num2} = {resta}");
                            contador++;
                            Console.WriteLine();
                            Console.Write(" Desea continuar? (S/N) : ");
                            continuar = Console.ReadLine();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("-----------------------");
                            Console.WriteLine(" +++ MULTIPLICACION +++");
                            Console.WriteLine("-----------------------");
                            Console.WriteLine();
                            multiplicacion = num1 * num2;
                            Console.WriteLine($" Multiplicacion = {num1} * {num2} = {multiplicacion}");
                            contador++;
                            Console.WriteLine();
                            Console.Write(" Desea continuar? (S/N) : ");
                            continuar = Console.ReadLine();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("-----------------");
                            Console.WriteLine(" +++ DIVISION +++");
                            Console.WriteLine("-----------------");
                            Console.WriteLine();
                            contador++;
                            if (num2 > 0)
                            {
                                division = num1 / num2;
                                Console.WriteLine($" Dividision = {num1} / {num2} = {division}");
                            }
                            else
                            {
                                Console.WriteLine(" ERROR No se puede Dividir en 0");
                                Console.WriteLine(" Ingresar un valor > 0 del divisor");
                                Console.ReadKey();
                                Console.WriteLine();
                                Console.Write(" Desea continuar? (S/N) : ");
                                continuar = Console.ReadLine();
                                break;
                            }
                            Console.WriteLine();
                            Console.Write(" Desea continuar? (S/N) : ");
                            continuar = Console.ReadLine();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine(" **********************************************");
                            Console.WriteLine(" | Para salir de la calculadora - Presionar N |");
                            Console.WriteLine(" **********************************************");
                            Console.WriteLine();
                            Console.Write(" Salida = ");
                            continuar = Console.ReadLine();
                            break;
                        }

                }
                Console.WriteLine();
                if (continuar == "S" || continuar == "s")
                {
                    Console.Write(" ¿Quiere ingresar nuevos numeros? (S/N) : ");
                    ingresoNuevo = Console.ReadLine();
                    if (ingresoNuevo == "S" || ingresoNuevo == "s")
                    {
                        contador = 0;
                    }
                }
                else
                {
                    break;
                }


            } 

            Console.ReadKey();
        }
    }
}
