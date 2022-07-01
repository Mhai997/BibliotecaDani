using Curso.Biblioteca.Aplicacion.Dto;
using Curso.Biblioteca.Aplicacion.ServiciosAplicacion;
using Microsoft.AspNetCore.Mvc;

namespace Curso.Biblioteca.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditorialController : ControllerBase, IEditorialServicio
    {
        private readonly IEditorialServicio editorialServicio;

        public EditorialController(IEditorialServicio editorialServicio)
        {
            this.editorialServicio = editorialServicio;
        }
        [HttpPut]
        public async Task<bool> ActualizarAsync(int id, CrearEditorialDto editorialDto)
        {
            return await editorialServicio.ActualizarAsync(id, editorialDto);
        }
        [HttpPost]
        public async Task<bool> CrearAsync(CrearEditorialDto editorial)
        {
            return await editorialServicio.CrearAsync(editorial);
        }
        [HttpDelete]
        public async Task<bool> EliminarAsync(int id)
        {
            return await editorialServicio.EliminarAsync(id);
        }
        [HttpGet("id")]
        public async Task<EditorialDto> ObtenerIdAsync(int id)
        {
            return await editorialServicio.ObtenerIdAsync(id);
        }
        [HttpGet]
        public async Task<ICollection<EditorialDto>> ObtenerTodosAsync()
        {
            return await editorialServicio.ObtenerTodosAsync();
        }
    }
}
