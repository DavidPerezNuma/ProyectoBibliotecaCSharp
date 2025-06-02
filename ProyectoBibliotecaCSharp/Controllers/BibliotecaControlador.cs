// Controllers/BibliotecaControlador.cs
using ProyectoBibliotecaCSharp.Models;
using ProyectoBibliotecaCSharp.Views;

namespace ProyectoBibliotecaCSharp.Controllers
{
    public class BibliotecaControlador
    {
        private readonly Biblioteca _bibliotecaModelo; 
        private readonly BibliotecaVista _bibliotecaVista;

        public BibliotecaControlador(Biblioteca modelo, BibliotecaVista vista)
        {
            _bibliotecaModelo = modelo;
            _bibliotecaVista = vista;
        }

        public void IniciarSimulacion()
        {
            _bibliotecaVista.MostrarMensaje("========= INICIANDO SIMULACIÓN DE BIBLIOTECA (C#) =========\n");

            PrepararLibros();
            MostrarCatalogo();

            _bibliotecaVista.MostrarMensaje("\n========= SIMULACIÓN TERMINADA (C#) =========\n");
        }

        private void PrepararLibros()
        {
            Libro libroBase1 = new Libro("Cien años de soledad", "Gabriel García Márquez");
            Libro libroBase2 = new Libro("El señor de los anillos", "J.R.R. Tolkien");
            Libro libroBase3 = new Libro("1984", "George Orwell");

            ILibroComponente libroTopVentas = new MasVendidoDecorator(libroBase1);
            ILibroComponente libroNovedad = new NovedadDecorator(libroBase3);

            _bibliotecaModelo.AgregarLibro(libroTopVentas);
            _bibliotecaVista.MostrarMensaje($"Info: Añadido '{libroBase1.Titulo}' a la biblioteca.");

            _bibliotecaModelo.AgregarLibro(libroBase2); 
            _bibliotecaVista.MostrarMensaje($"Info: Añadido '{libroBase2.Titulo}' a la biblioteca.");

            _bibliotecaModelo.AgregarLibro(libroNovedad);
            _bibliotecaVista.MostrarMensaje($"Info: Añadido '{libroBase3.Titulo}' a la biblioteca.");
        }

        private void MostrarCatalogo()
        {
            IReadOnlyList<ILibroComponente> libros = _bibliotecaModelo.Libros;
            _bibliotecaVista.MostrarCatalogo(libros);
        }
    }
}
