using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YashroSuma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar = "si";

            while (continuar.ToLower() == "si")
            {
                Sumar();
                Console.WriteLine("¿Deseas realizar otra suma? (si/no):");
                continuar = Console.ReadLine();
            }

            Console.WriteLine("Proceso finalizado. Presiona cualquier tecla para salir.");
            Console.ReadKey();
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
    }
}
