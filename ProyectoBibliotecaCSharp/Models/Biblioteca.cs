// Models/Biblioteca.cs
using System.Collections.Generic; 
using System.Linq; 

namespace ProyectoBibliotecaCSharp.Models
{
    public class Biblioteca
    {
        private readonly List<ILibroComponente> _libros = new List<ILibroComponente>();
        public IReadOnlyList<ILibroComponente> Libros => _libros.AsReadOnly();

        public void AgregarLibro(ILibroComponente libro)
        {
            _libros.Add(libro);
        }
    }
}
