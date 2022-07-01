using Curso.Biblioteca.Aplicacion.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Aplicacion.ServiciosAplicacion
{
    public interface IAutorServicio
    {
        Task<ICollection<AutorDto>> ObtenerTodosAsync();
        //GetById
        Task<AutorDto> ObtenerIdAsync(int id);
        //create
        Task<bool> CrearAsync(CrearAutorDto autor);
        Task<bool> ActualizarAsync(int id, CrearAutorDto autorDto);

        Task<bool> EliminarAsync(int id);
    }
}
