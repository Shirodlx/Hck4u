using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario
{
    public class Persona
    {
        private List<Persona> personas = new List<Persona>();
        public string Nombre { get; set; }
        public string Rut { get; set; }
        public int Edad { get; set; }

        public Persona() { }

        public void CrearPersona()
        {
            try
            {
                Persona persona = new Persona();
                Console.Write("Nombre: ");
                persona.Nombre = Console.ReadLine();
                Console.Write("Rut: ");
                persona.Rut = Console.ReadLine();
                Console.Write("Edad: ");
                persona.Edad = int.Parse(Console.ReadLine());
                personas.Add(persona);
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato no correcto");
            }
        }

        public void MostrarPersonas()
        {
            Console.WriteLine("\nLista de personas ingresadas:");
            for (int i = 0; i < personas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {personas[i].Nombre}, {personas[i].Rut}, {personas[i].Edad}");
            }
        }
        public void ModificarNombre()
        {
            MostrarPersonas();
            Console.Write("Selecciona el número de la persona a modificar su Nombre: ");
            try
            {
                int index = int.Parse(Console.ReadLine()) - 1;
                if (index < 0 || index >= personas.Count)
                {
                    Console.WriteLine("Índice fuera de rango.");
                    return;
                }

                Console.Write("Nuevo nombre: ");
                string nuevoNombre = Console.ReadLine();
                personas[index].Nombre = nuevoNombre;
                Console.WriteLine("Nombre modificado correctamente.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato no correcto.");
            }
        }
        public void ModificarRut()
        {
            MostrarPersonas();
            Console.Write("Selecciona el número de la persona a modificar su Rut: ");
            try
            {
                int index = int.Parse(Console.ReadLine()) - 1;
                if (index < 0 || index >= personas.Count)
                {
                    Console.WriteLine("Índice fuera de rango.");
                    return;
                }

                Console.Write("Nuevo Rut: ");
                string nuevoRut = Console.ReadLine();
                personas[index].Rut = nuevoRut;
                Console.WriteLine("Rut modificado correctamente.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato no correcto.");
            }
        }
        public void ModificarEdad()
        {
            MostrarPersonas();
            Console.Write("Selecciona el número de la persona a modificar su Edad: ");
            try
            {
                int index = int.Parse(Console.ReadLine()) - 1;
                if (index < 0 || index >= personas.Count)
                {
                    Console.WriteLine("Índice fuera de rango.");
                    return;
                }

                Console.Write("Nueva Edad: ");
                int nuevaEdad = int.Parse(Console.ReadLine());
                personas[index].Edad = nuevaEdad;
                Console.WriteLine("Rut modificado correctamente.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato no correcto.");
            }
        }
    }
}

