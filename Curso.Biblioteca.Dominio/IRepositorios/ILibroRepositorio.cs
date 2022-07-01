using Curso.Biblioteca.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Dominio.IRepositorios
{
    public interface ILibroRepositorio
    {
        IQueryable<Libro> ObtenerTodos();
        Task CrearAsync(Libro libro);
        Task ActualizarAsync(Libro libro);

        Task EliminarAsync(Libro libro);
    }
}
