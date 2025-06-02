// Models/MasVendidoDecorator.cs
namespace ProyectoBibliotecaCSharp.Models
{
    public class MasVendidoDecorator : LibroDecorator
    {
        public MasVendidoDecorator(ILibroComponente componenteLibro) : base(componenteLibro) { }

        public override string Mostrar()
        {
            return base.Mostrar() + " (El más vendido)";
        }
    }
}
