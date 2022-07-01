using Curso.Biblioteca.Aplicacion.Dto;
using Curso.Biblioteca.Aplicacion.ServiciosAplicacion;
using Microsoft.AspNetCore.Mvc;

namespace Curso.Biblioteca.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase, IAutorServicio
    {
        private readonly IAutorServicio autorServicio;

        public AutorController(IAutorServicio autorServicio)
        {
            this.autorServicio = autorServicio;
        }
        [HttpPut]
        public async Task<bool> ActualizarAsync(int id, CrearAutorDto autorDto)
        {
            return await autorServicio.ActualizarAsync(id, autorDto);
        }
        [HttpPost]
        public async Task<bool> CrearAsync(CrearAutorDto autor)
        {
            return await autorServicio.CrearAsync(autor);
        }
        [HttpDelete]
        public async Task<bool> EliminarAsync(int id)
        {
            return await autorServicio.EliminarAsync(id);
        }
        [HttpGet("id")]
        public async Task<AutorDto> ObtenerIdAsync(int id)
        {
            return await autorServicio.ObtenerIdAsync(id);
        }
        [HttpGet]
        public async Task<ICollection<AutorDto>> ObtenerTodosAsync()
        {
            return await autorServicio.ObtenerTodosAsync();
        }
    }
}
