using Curso.Biblioteca.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Dominio.IRepositorios
{
    public interface IEditorialRepositorio
    {
        IQueryable<Editorial> ObtenerTodos();
        Task CrearAsync(Editorial editorial);
        Task ActualizarAsync(Editorial editorial);

        Task EliminarAsync(Editorial editorial);
    }
}
