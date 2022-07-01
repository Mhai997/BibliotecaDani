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
    public class LibroServicio : ILibroServicio
    {
        private readonly ILibroRepositorio libroRepositorio;

        public LibroServicio(ILibroRepositorio libroRepositorio)
        {
            this.libroRepositorio = libroRepositorio;
        }

        public async Task<bool> CrearAsync(CrearLibroDto libro)
        {
            var entidad = new Libro
            {
                Titulo = libro.Titulo,
                ISBN = libro.ISBN,
                AutorId = libro.AutorId,
                EditorialId = libro.EditorialId
            };
            await libroRepositorio.CrearAsync(entidad);
            return true;
        }
        public async Task<bool> EliminarAsync(int id)
        {
            var consulta = libroRepositorio.ObtenerTodos();
            consulta = consulta.Where(c => c.Id == id);
            var libro = consulta.SingleOrDefault();

            await libroRepositorio.EliminarAsync(libro);
            return true;
        }
        public async Task<ICollection<LibroDto>> ObtenerTodosAsync()
        {
            var consulta = libroRepositorio.ObtenerTodos();
            var ListaLibros = await consulta.Select(x => new LibroDto
            {
                Id = x.Id,
                Titulo = x.Titulo,
                ISBN = x.ISBN,
                Autor = $"{x.Autor.Nombre} {x.Autor.Apellido}",
                Editorial = $"{x.Editorial.Nombre}"
            }).ToListAsync();

            return ListaLibros;
        }
        public async Task<LibroDto> ObtenerIdAsync(int id)
        {
            var consulta = libroRepositorio.ObtenerTodos();
            consulta = consulta.Where(c => c.Id == id);
            var ListaLibros = await consulta.Select(x => new LibroDto
            {
                Id = x.Id,
                Titulo = x.Titulo,
                ISBN = x.ISBN,
                Autor = $"{x.Autor.Nombre} {x.Autor.Apellido}",
                Editorial = $"{x.Editorial.Nombre}"
            }).SingleOrDefaultAsync();

            return ListaLibros;
        }
        public async Task<bool> ActualizarAsync(int id, CrearLibroDto libroDto)
        {
            var consulta = libroRepositorio.ObtenerTodos();
            consulta = consulta.Where(c => c.Id == id);
            var libro = consulta.SingleOrDefault();
            libro.Titulo = libroDto.Titulo;
            libro.ISBN = libroDto.ISBN;

            await libroRepositorio.ActualizarAsync(libro);
            return true;

        }

        
       

        

      
    }
}
