using discografiaparcial.repositories;
using discografiaparcial.Models;
using System.ComponentModel.Design;


int opcion;
do
{
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("1. Agregar cantante");
    Console.WriteLine("2. Agregar canción");
    Console.WriteLine("3. Listar canciones");
    Console.WriteLine("4. mostrar cancion mas larga"); 
    Console.WriteLine("5. mostrar todas las canciones");
    Console.WriteLine("6. mostrar canciones alfabeticamente");
    Console.WriteLine("7. canciones registradas");
    Console.WriteLine("8. Salir");  
    int.TryParse(Console.ReadLine(), out opcion);  
    Console.Clear(); 
    switch (opcion)
    {
        case 1:
            Genericrepository<cantante> cantanteRepository = new Genericrepository<cantante>();
            Console.WriteLine("ingrese nombre del cantante");
            string nombreCantante = Console.ReadLine();
            cantanteRepository.Agregar(new cantante { Nombre = nombreCantante });
            Console.WriteLine("Cantante agregado exitosamente.");
            Console.ReadKey();  


            break;
        case 2:
            Genericrepository<cancion> cancionRepository = new Genericrepository<cancion>();
            Genericrepository<cantante> cantanteRepository = new Genericrepository<cantante>();
            Console.WriteLine("Ingrese el título de la canción: ");
            string tituloCancion = Console.ReadLine();
            Console.WriteLine("ingrese duración: ");
            int duracion = int.Parse(Console.ReadLine());
            foreach (var cantante in cantanteRepository.ObtenerTodos())
            {
                Console.WriteLine($"ID: {cantante.Id}, Nombre: {cantante.Nombre}");
            }
            Console.WriteLine("Ingrese el ID del cantante de la canción: ");
            int idCantante = int.Parse(Console.ReadLine());
            foreach (var cantante in cantanteRepository.ObtenerTodos())
            {
                if (cantante.Id == idCantante)
                {
                    cancionRepository.Agregar(new cancion { Titulo = tituloCancion, Duracion = duracion, CantanteId = idCantante });
                    Console.WriteLine("Canción registrada con éxito.");
                    break;
                }
            }
            break;
                Console.WriteLine($"ID: {autor.Id}, Nombre: {autor.Nombre}");
            }
            Console.WriteLine("Ingrese el ID del autor del libro: ");
            int idAutor = int.Parse(Console.ReadLine());
            foreach (var autor in autorRepository.ObtenerTodos())
            {
                if (autor.Id == idAutor)
                {
                    libroRepository.Agregar(new libro { Titulo = tituloLibro, Anio = anioLibro, AutorId = idAutor });
                    Console.WriteLine("Libro registrado con éxito.");
                    break;

                }
                else
                {
                    Console.WriteLine("El ID del autor ingresado no existe. Por favor, registre el autor primero.");
                    break;

                    break;
        case 3:
            genericrepository<cancion> cancionrepository = new Genericrepository<cancion>();
                foreach (var cancion in cancionrepository.ObtenerTodos())   
                    Console.WriteLine($"ID: {cancion.Id}, Título: {cancion.Titulo}, Duración: {cancion.Duracion}, Cantante ID: {cancion.CantanteId}");
                break;
        case 4:
            genericrepository<cancion> cancionrepository = new Genericrepository<cancion>();
                foreach (var cancion in cancionrepository.ObtenerTodos())  
                    Console.WriteLine ($"duracion: {cancion.Duracion}, Titulo: {cancion.Titulo}"); 

                    break;
        case 5:
            var cancionRepo3 = new cancionRepository();
            cancionRepo3.MostrarTodasLasCanciones();
            break;
        case 6:
            var cancionRepo4 = new cancionRepository();
            cancionRepo4.MostrarCancionesAlfabeticamente();
            break;
        case 7:
            var cantanteRepo = new cantanteRepository();
            cantanteRepo.CancionesRegistradasPorCantante();
            break;
        case 8:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción inválida. Intente nuevamente.");
            break;
    }




















}

