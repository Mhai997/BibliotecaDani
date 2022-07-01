using Curso.Biblioteca.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Dominio.IRepositorios
{
    public interface IAutorRepositorio
    {
        IQueryable<Autor> ObtenerTodos();
        Task CrearAsync(Autor autor);
        Task ActualizarAsync(Autor autor);

        Task EliminarAsync(Autor autor);
    }
}
