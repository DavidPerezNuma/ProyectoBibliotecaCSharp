# Proyecto: Sistema de Gestión de Biblioteca en C#

## 1. Introducción

Este proyecto es una aplicación de consola en C# que simula la gestión de una biblioteca. Su propósito principal es demostrar de manera práctica la aplicación de conceptos clave de ingeniería de software y características avanzadas de la Programación Orientada a Objetos (POO), incluyendo:
* Una arquitectura similar a **Modelo-Vista-Controlador (MVC)**.
* Principios fundamentales de la **Programación Orientada a Objetos (POO)** como abstracción, encapsulamiento, herencia y polimorfismo.
* El principio **SOLID** de Responsabilidad Única (SRP).
* El patrón de diseño **Decorator**.

Este proyecto fue desarrollado como parte de una actividad para evidenciar los conceptos de POO avanzada, utilizando C# y .NET.

## 2. Video Explicativo

Puedes ver una explicación detallada del programa, su funcionalidad y la aplicación de los conceptos de POO en el siguiente video:


[ProyectoBibliotecaCSharp.mp4](https://unisalleedu-my.sharepoint.com/:v:/g/personal/juperez49_unisalle_edu_co/EUJ08vQ3nINAgiHoyXJ002QBvbjBnpYfiKxl6deEa4K17Q?e=Cqco5N)

## 3. Arquitectura (Tipo MVC)

El proyecto está estructurado siguiendo una separación de responsabilidades inspirada en el patrón MVC para lograr mayor claridad y mantenibilidad:

* **Modelos (`/Models`)**: Contienen toda la lógica de negocio y los datos. Son responsables de gestionar el estado de la aplicación (qué libros hay, cómo se definen y decoran) pero no saben cómo se presentan estos datos al usuario.
    * `ILibroComponente.cs`: Interfaz que define el comportamiento común para libros y sus decoradores.
    * `Libro.cs`: Clase concreta que representa un libro básico.
    * `Biblioteca.cs`: Clase que gestiona la colección de libros.
    * `LibroDecorator.cs`: Clase base abstracta para los decoradores de libros.
    * `MasVendidoDecorator.cs`: Decorador concreto para marcar un libro como "El más vendido".
    * `NovedadDecorator.cs`: Decorador concreto para marcar un libro como "¡Novedad!".
* **Vista (`/Views`)**: Es la capa de presentación. Su única responsabilidad es mostrar la información que le entrega el controlador. En esta aplicación, se encarga de imprimir mensajes y el catálogo en la consola.
    * `BibliotecaVista.cs`
* **Controlador (`/Controllers`)**: Actúa como el intermediario entre el Modelo y la Vista. Recibe las peticiones (en este caso, inicia la simulación), le da instrucciones al Modelo para que actualice su estado y luego selecciona una Vista para que presente los datos del Modelo.
    * `BibliotecaControlador.cs`

El archivo `Program.cs` funciona como el punto de entrada de la aplicación, inicializando y conectando estos tres componentes.

## 4. Programación Orientada a Objetos (POO)

La POO se evidencia a través de varias características avanzadas de C#:
* **Abstracción**: La interfaz `ILibroComponente` define un contrato que deben cumplir tanto los libros como sus decoradores, permitiendo tratarlos de forma uniforme.
* **Encapsulamiento**: Clases como `Libro` (con propiedades `Titulo` y `Autor` con `private set`) y `Biblioteca` (con su lista privada `_libros`) ocultan su estado interno y exponen operaciones a través de métodos públicos.
* **Herencia**: La clase abstracta `LibroDecorator` hereda de `ILibroComponente` y sirve como base para decoradores concretos como `MasVendidoDecorator` y `NovedadDecorator`, los cuales extienden o modifican el comportamiento.
* **Polimorfismo**: El método `Mostrar()` es implementado por `Libro` y sobrescrito por los decoradores. Esto permite que el mismo método se comporte de manera diferente según el tipo de objeto en tiempo de ejecución. La colección `List<ILibroComponente>` en `Biblioteca` puede almacenar diferentes implementaciones de `ILibroComponente`.

## 5. Principio SOLID: Responsabilidad Única (SRP)

El Principio de Responsabilidad Única establece que una clase debe tener una sola razón para cambiar. Este principio se aplica de dos maneras principales en el proyecto:

1.  **A nivel de clase**:
    * La clase `Biblioteca` se ocupa únicamente de la lógica de la colección de libros (agregar, acceder).
    * La clase `Libro` solo se ocupa de los datos y la representación básica de un libro.
    * La clase `BibliotecaVista` solo es responsable de mostrar información en la consola.
2.  **A nivel de arquitectura**: La estructura MVC (o similar) es en sí una aplicación a gran escala del SRP.
    * Los **Modelos** solo tienen razones para cambiar si la lógica de negocio o la estructura de datos cambia.
    * La **Vista** solo cambia si la forma de presentar la información al usuario cambia.
    * El **Controlador** solo cambia si el flujo de la aplicación o la coordinación entre Modelo y Vista necesita ajustes.

## 6. Patrón de Diseño: Decorator

Se utiliza el patrón Decorator para añadir responsabilidades y modificar el comportamiento de los objetos `Libro` de forma dinámica y flexible, sin necesidad de alterar la clase `Libro` directamente o recurrir a una jerarquía de herencia compleja.

* **Componente (`ILibroComponente`)**: Es la interfaz común tanto para los objetos que se van a decorar como para los decoradores mismos.
* **Componente Concreto (`Libro`)**: Es la clase base a la que se le añaden las decoraciones. Implementa `ILibroComponente`.
* **Decorador Abstracto (`LibroDecorator`)**: Mantiene una referencia a un objeto `ILibroComponente` (el objeto envuelto) y delega las operaciones a este. También implementa `ILibroComponente`.
* **Decoradores Concretos (`NovedadDecorator`, `MasVendidoDecorator`)**: Son clases que "envuelven" a un `ILibroComponente` (que puede ser un `Libro` o incluso otro decorador) y añaden una funcionalidad extra al método `Mostrar()` antes o después de delegar la llamada al objeto envuelto. Esto permite marcar un libro como "[¡Novedad!]" o "(El más vendido)" sin crear subclases específicas de `Libro` para cada combinación de características.

## 7. Instalación y Ejecución

1.  **Prerrequisitos**:
    * Asegúrate de tener instalado el SDK de .NET (Este proyecto utiliza .NET 8.0). Puedes descargarlo desde [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).
2.  **Configuración**:
    * Clona o descarga este repositorio.
    * Los archivos ya están organizados en la estructura de carpetas descrita (`Models`, `Views`, `Controllers`).
3.  **Ejecución**:
    * Abre una terminal o línea de comandos.
    * Navega hasta el directorio raíz del proyecto (la carpeta que contiene el archivo `.csproj`, por ejemplo, `ProyectoBibliotecaCSharp/`).
    * Ejecuta el siguiente comando:
        ```bash
        dotnet run
        ```
    * Esto compilará y ejecutará la aplicación, y deberías ver la simulación de la biblioteca en la consola.