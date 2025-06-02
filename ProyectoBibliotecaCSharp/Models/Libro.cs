// Models/Libro.cs
namespace ProyectoBibliotecaCSharp.Models
{
    public class Libro : ILibroComponente
    {
        public string Titulo { get; private set; } 
        public string Autor { get; private set; }  

        public Libro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }

        public virtual string Mostrar()
        {
            return $"\"{Titulo}\" por {Autor}";
        }
    }
}
