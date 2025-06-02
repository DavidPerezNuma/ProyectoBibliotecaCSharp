// Program.cs
using ProyectoBibliotecaCSharp.Models;
using ProyectoBibliotecaCSharp.Views;
using ProyectoBibliotecaCSharp.Controllers;

namespace ProyectoBibliotecaCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Crear instancia del Modelo
            Biblioteca bibliotecaModelo = new Biblioteca();

            // 2. Crear instancia de la Vista
            BibliotecaVista bibliotecaVista = new BibliotecaVista();

            // 3. Crear instancia del Controlador, inyectando el modelo y la vista
            BibliotecaControlador controlador = new BibliotecaControlador(bibliotecaModelo, bibliotecaVista);

            // 4. Iniciar la aplicación
            controlador.IniciarSimulacion();
        }
    }
}
