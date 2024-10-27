using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar = "si";
            Persona persona = new Persona();
            while (continuar.ToLower() == "si")
            {
                
                Console.WriteLine("Eligue una opción:");
                Console.WriteLine("1. Crear persona.");
                Console.WriteLine("2. Mostrar personas.");
                Console.WriteLine("3. Modificar Atributo.");
                Console.WriteLine("4. SALIR.");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        persona.CrearPersona();
                        break;
                    case "2":
                        persona.MostrarPersonas();
                        break;
                    case "3":
                        Console.WriteLine("¿Qué deseas modificar?");
                        Console.WriteLine("1. Nombre.");
                        Console.WriteLine("2. Rut");
                        Console.WriteLine("3. Edad)");
                        int modificar = Convert.ToInt32(Console.ReadLine());
                        if (modificar == 1)
                        {
                            persona.ModificarNombre();
                        }
                        else if (modificar == 2)
                        {
                            persona.ModificarRut();
                        }
                        else if (modificar == 3)
                        {
                            persona.ModificarEdad();
                        }
                        else
                        {
                            Console.WriteLine("Opción no valida.");
                        }
                        break;

                    case "4":
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, elige una opción del 1 al 4.");
                        break;
                }
                Console.WriteLine("¿Deseas realizar otra operación? (si/no):");
                continuar = Console.ReadLine();
            }
        }
    }
}