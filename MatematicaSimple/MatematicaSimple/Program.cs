using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematicaSimple

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar = "si";

            while (continuar.ToLower() == "si")
            {
                Console.WriteLine("Elige una operación:");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("Ingresa el número de la operación que deseas realizar:");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Sumar();
                        break;
                    case "2":
                        Restar();
                        break;
                    case "3":
                        Multiplicar();
                        break;
                    case "4":
                        Dividir();
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, elige una opción del 1 al 4.");
                        break;
                }
                Console.WriteLine("¿Deseas realizar otra operación? (si/no):");
                continuar = Console.ReadLine();
            }
        }

        public static void Sumar()
        {
            try
            {
                Console.WriteLine("Ingresa un Número");
                int numA = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa el siguiente número");
                int numB = Convert.ToInt32(Console.ReadLine());

                int resultado = numA + numB;
                Console.WriteLine("El resultado es: " + resultado);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingresa un número válido.");
            }
        }

        public static void Restar()
        {
            try
            {
                Console.WriteLine("Ingresa un Número");
                int numA = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa el siguiente número");
                int numB = Convert.ToInt32(Console.ReadLine());

                int resultado = numA - numB;
                Console.WriteLine("El resultado es: " + resultado);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingresa un número válido.");
            }
        }

        public static void Multiplicar()
        {
            try
            {
                Console.WriteLine("Ingresa un Número");
                double numA = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingresa el siguiente número");
                double numB = Convert.ToDouble(Console.ReadLine());

                double resultado = numA * numB;
                Console.WriteLine("El resultado es: " + resultado);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingresa un número válido.");
            }
        }

        public static void Dividir()
        {
            try
            {
                Console.WriteLine("Ingresa un Número");
                double numA = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingresa el siguiente número");
                double numB = Convert.ToDouble(Console.ReadLine());

                if (numB != 0)
                {
                    double resultado = numA / numB;
                    Console.WriteLine("El resultado es: " + resultado);
                }
                else
                {
                    Console.WriteLine("No se puede dividir entre cero.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingresa un número válido.");
            }
        }
    }
}
