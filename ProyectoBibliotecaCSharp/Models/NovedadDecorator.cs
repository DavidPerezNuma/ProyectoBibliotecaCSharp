// Models/NovedadDecorator.cs
namespace ProyectoBibliotecaCSharp.Models
{
    public class NovedadDecorator : LibroDecorator
    {
        public NovedadDecorator(ILibroComponente componenteLibro) : base(componenteLibro) { }

        public override string Mostrar()
        {
            return base.Mostrar() + " [¡Novedad!]"; 
        }
    }
}
