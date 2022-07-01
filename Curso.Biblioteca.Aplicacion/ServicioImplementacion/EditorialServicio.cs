using Curso.Biblioteca.Aplicacion.Dto;
using Curso.Biblioteca.Aplicacion.ServiciosAplicacion;
using Curso.Biblioteca.Dominio.Entidades;
using Curso.Biblioteca.Dominio.IRepositorios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Aplicacion.ServicioImplementacion
{
    public class EditorialServicio : IEditorialServicio
    {
        private readonly IEditorialRepositorio editorialRepositorio;

        public EditorialServicio(IEditorialRepositorio editorialRepositorio)
        {
            this.editorialRepositorio = editorialRepositorio;
        }

        public async Task<bool> CrearAsync(CrearEditorialDto editorial)
        {
            var entidad = new Editorial
            {
                Nombre = editorial.Nombre,
                Direccion=editorial.Direccion
              
            };
            await editorialRepositorio.CrearAsync(entidad);
            return true;
        }
        public async Task<bool> EliminarAsync(int id)
        {
            var consulta = editorialRepositorio.ObtenerTodos();
            consulta = consulta.Where(c => c.Id == id);
            var editorial = consulta.SingleOrDefault();

            await editorialRepositorio.EliminarAsync(editorial);
            return true;
        }
        public async Task<ICollection<EditorialDto>> ObtenerTodosAsync()
        {
            var consulta = editorialRepositorio.ObtenerTodos();
            var ListaEditorials = await consulta.Select(x => new EditorialDto
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Direccion = x.Direccion
            
            }).ToListAsync();

            return ListaEditorials;
        }
        public async Task<EditorialDto> ObtenerIdAsync(int id)
        {
            var consulta = editorialRepositorio.ObtenerTodos();
            consulta = consulta.Where(c => c.Id == id);
            var ListaEditorials = await consulta.Select(x => new EditorialDto
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Direccion = x.Direccion
            }).SingleOrDefaultAsync();

            return ListaEditorials;
        }
        public async Task<bool> ActualizarAsync(int id, CrearEditorialDto editorialDto)
        {
            var consulta = editorialRepositorio.ObtenerTodos();
            consulta = consulta.Where(c => c.Id == id);
            var editorial = consulta.SingleOrDefault();
            editorial.Nombre = editorialDto.Nombre;
            editorial.Direccion = editorialDto.Direccion;
           

            await editorialRepositorio.ActualizarAsync(editorial);
            return true;

        }

        
       

        

      
    }
}
