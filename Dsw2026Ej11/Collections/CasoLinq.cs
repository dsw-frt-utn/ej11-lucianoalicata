using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    private IEnumerable<Libro> _libros=Libro.CrearLista();

    //obtener el primer libro
    public Libro GetPrimero()
    {
        return _libros.First();
    }
    //obtener el ultimo libro
    public Libro GetUltimo()
    {
        return _libros.Last();
    }
    //suma de precios de todos los libros
    public decimal GetTotalPrecios()
    {
        return _libros.Sum(libro => libro.Precio);
    }
    //promedio de precios
    public decimal GetPromedioPrecios()
    {
        return _libros.Average(p => p.Precio);
    }
    //listar libros q tengan id>15
    public List<Libro> GetListById()
    {
        return _libros.Where(libro => libro.Id > 15 ).ToList();
    }
    //lista de libros, nombre y precio
    public List<string> GetLibros()
    {
        return _libros.Select(libro => $"{libro.Titulo} - {libro.Precio.ToString("C")}").ToList();
    }
    //mostrar el libro más caro
    public Libro GetMayorPrecio()
    {
        return _libros.OrderByDescending(libro => libro.Precio).First();
    }
    //mostrar el libro más barato
    public Libro GetMenorPrecio()
    {
        return _libros.OrderBy(libro => libro.Precio).First();
    }
    //obtener libros cuyo precio sea mayor al promedio
    public List<Libro> GetMayorPromedio()
    {
        decimal promedio = _libros.Average(libro => libro.Precio);
        return _libros.Where(libro => libro.Precio > promedio).ToList();
    }
    //lista de libros ordenada por titulo descendentemente
    public List<Libro> GetOrdenadosPorTitulo()
    {
        return _libros.OrderByDescending(libro => libro.Titulo).ToList();
    }
}
