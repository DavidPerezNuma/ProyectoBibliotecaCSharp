// Views/BibliotecaVista.cs
using System; 
using System.Collections.Generic;
using ProyectoBibliotecaCSharp.Models; 

namespace ProyectoBibliotecaCSharp.Views
{
    public class BibliotecaVista
    {
        public void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        public void MostrarCatalogo(IReadOnlyList<ILibroComponente> libros)
        {
            Console.WriteLine("\n--- Catálogo de la Biblioteca ---");
            if (libros == null || libros.Count == 0)
            {
                Console.WriteLine("La biblioteca está vacía.");
            }
            else
            {
                foreach (var libro in libros)
                {
                    Console.WriteLine($"- {libro.Mostrar()}");
                }
            }
            Console.WriteLine("---------------------------------");
        }
    }
}
