// Models/LibroDecorator.cs
namespace ProyectoBibliotecaCSharp.Models
{
    public abstract class LibroDecorator : ILibroComponente
    {
        protected ILibroComponente _componenteLibro;

        protected LibroDecorator(ILibroComponente componenteLibro)
        {
            _componenteLibro = componenteLibro;
        }

        public virtual string Mostrar()
        {
            return _componenteLibro.Mostrar();
        }
    }
}
