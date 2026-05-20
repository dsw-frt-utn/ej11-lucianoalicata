using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    
    public static void EjemploList()
    {
        //creo CasoList y le agrego alumnos. 
        CasoList cl = new CasoList();
        Alumno a1 = new Alumno(1,"Pérez, Lucas",9.5);
        Alumno a2 = new Alumno(2,"Alicata, Luciano",8.5);
        Alumno a3 = new Alumno(3,"Díaz, Pablo",7.5);
        cl.AgregarAlumno(a1);
        cl.AgregarAlumno(a2);
        cl.AgregarAlumno(a3);
        
        //mostrar listado de alumnos
        Console.WriteLine("========== LISTA DE ALUMNOS ==========");
        cl.GetLista();
        Console.WriteLine("");
        
        //buscar por nombre
        Console.WriteLine("========== BUSCAR POR NOMBRE ('Alicata, Luciano') ==========");
        cl.GetAlumno("Alicata, Luciano");
        Console.WriteLine("");
        
        //buscar alumno que no existe
        Console.WriteLine("========== BUSCAR ALUMNO INEXISTENTE ('Gómez, Juan') ==========");
        cl.GetAlumno("Gómez, Juan");
        Console.WriteLine("");
        
        //eliminar alumno
        Console.WriteLine("========== ELIMINAR ALUMNO ('Díaz, Pablo') ==== NUEVA LISTA DE ALUMNOS ====");
        cl.EliminarAlumno(a3);
        cl.GetLista();
        Console.WriteLine("");
        
        //eliminar 1er alumno de la lista
        Console.WriteLine("========== ELIMINAR 1er AlLUMNO ('Pérez, Lucas') ==== NUEVA LISTA DE ALUMNOS ====");
        cl.EliminarAlumnoPorIndice(0);
        cl.GetLista();
        Console.WriteLine("");
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary caso = new CasoDictionary();
        caso.AgregarAlumno(new Alumno(1, "Aguilar, Gabriel", 8.5));
        caso.AgregarAlumno(new Alumno(2, "Herrera, Juliana", 9.0));
        caso.AgregarAlumno(new Alumno(3, "Romero, Carlos", 6.5));
        
        
        //listar alumnos
        Console.WriteLine("============= LISTA DE ALUMNOS =============");
        foreach (var par in caso.GetDiccionario())
        {
            Console.WriteLine($"Clave: {par.Key} - {par.Value.Nombre} - Promedio: {par.Value.Promedio}");
        }
        Console.WriteLine("");
        
        //buscar por clave y mostrar por consola
        Console.WriteLine("========== BUSCAR ALUMNO POR CLAVE (clave: 2) ==========");
        caso.GetAlumnoPorClave(2);
        Console.WriteLine("");
        
        //buscar por clave que no exista y mostrar el texto "no existe"
        Console.WriteLine("========== BUSCAR ALUMNO QUE NO EXISTE (clave: 5) ==========");
        caso.GetAlumnoPorClave(5);
        Console.WriteLine("");
        
        //eliminar alumno por clave y listar alumnos
        Console.WriteLine("========== ELIMINAR ALUMNO (clave: 2) ==========");
        caso.EliminarAlumno(2);
        foreach (var par in caso.GetDiccionario())
            Console.WriteLine($"Clave: {par.Key} - {par.Value.Nombre} - Promedio: {par.Value.Promedio}");
        Console.WriteLine("");

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

    }
}
