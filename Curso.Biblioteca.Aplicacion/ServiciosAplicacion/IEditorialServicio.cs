using Curso.Biblioteca.Aplicacion.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Aplicacion.ServiciosAplicacion
{
    public interface IEditorialServicio
    {
        Task<ICollection<EditorialDto>> ObtenerTodosAsync();
        //GetById
        Task<EditorialDto> ObtenerIdAsync(int id);
        //create
        Task<bool> CrearAsync(CrearEditorialDto editorial);
        Task<bool> ActualizarAsync(int id, CrearEditorialDto editorialDto);

        Task<bool> EliminarAsync(int id);
    }
}
