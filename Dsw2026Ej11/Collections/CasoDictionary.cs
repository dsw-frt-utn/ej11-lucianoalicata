using Dsw2026Ej11.Domain;
namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    Dictionary<int, Alumno> dicc =  new Dictionary<int, Alumno>();

    public void AgregarAlumno(Alumno alumno)
    {
        if (alumno != null)
        dicc.Add(alumno.Id, alumno);
    }

    public Alumno? GetAlumnoPorClave(int clave)
    {
        dicc.TryGetValue(clave, out Alumno? a);
        Console.WriteLine(a != null ? $"{a.Id} - {a.Nombre} - {a.Promedio}" : "No existe");
        return a;
    }
    
    public Dictionary<int, Alumno> GetDiccionario()
    {
        return dicc;
    }
    
    public void EliminarAlumno(int clave)
    {
        dicc.Remove(clave);
    }
}
