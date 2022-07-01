using Curso.Biblioteca.Aplicacion.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Aplicacion.ServiciosAplicacion
{
    public interface ILibroServicio
    {
        Task<ICollection<LibroDto>> ObtenerTodosAsync();
        //GetById
        Task<LibroDto> ObtenerIdAsync(int id);
        //create
        Task<bool> CrearAsync(CrearLibroDto libro);
        Task<bool> ActualizarAsync(int id, CrearLibroDto libroDto);

        Task<bool> EliminarAsync(int id);
    }
}
