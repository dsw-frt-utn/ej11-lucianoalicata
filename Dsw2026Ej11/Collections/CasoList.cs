using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    List<Alumno>? lista = new List<Alumno>();

    public void AgregarAlumno(Alumno alumno)
    {
        if (alumno != null)
        {
            lista.Add(alumno);
        }
    }

    public void GetLista()
    {
        foreach (var Alumno in lista)
        {
            Console.WriteLine(Alumno);
        }
    }

    public Alumno? GetAlumno(string nombreBuscar)
    {
        Alumno? a = lista.Find(a => a.Nombre == nombreBuscar);
        Console.WriteLine(a!=null ? $"{a.Id} - {a.Nombre} - Promedio: {a.Promedio}" : "No existe");
        return a;
    }

    public void EliminarAlumno(Alumno alumno)
    {
        lista.Remove(alumno);
    }
    
    public void EliminarAlumnoPorIndice(int indice)
    {
        lista.RemoveAt(indice);
    }
}
