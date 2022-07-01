using Curso.Biblioteca.Aplicacion.Dto;
using Curso.Biblioteca.Aplicacion.ServiciosAplicacion;
using Microsoft.AspNetCore.Mvc;

namespace Curso.Biblioteca.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase, ILibroServicio
    {
        private readonly ILibroServicio libroServicio;

        public LibroController(ILibroServicio libroServicio)
        {
            this.libroServicio = libroServicio;
        }
        [HttpPut]
        public async Task<bool> ActualizarAsync(int id, CrearLibroDto libroDto)
        {
            return await libroServicio.ActualizarAsync(id, libroDto);
        }
        [HttpPost]
        public async Task<bool> CrearAsync(CrearLibroDto libro)
        {
            return await libroServicio.CrearAsync(libro);
        }
        [HttpDelete]
        public async Task<bool> EliminarAsync(int id)
        {
            return await libroServicio.EliminarAsync(id);
        }
        [HttpGet("id")]
        public async Task<LibroDto> ObtenerIdAsync(int id)
        {
            return await libroServicio.ObtenerIdAsync(id);
        }
        [HttpGet]
        public async Task<ICollection<LibroDto>> ObtenerTodosAsync()
        {
            return await libroServicio.ObtenerTodosAsync();
        }
    }
}
