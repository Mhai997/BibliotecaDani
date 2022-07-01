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
    public class AutorServicio : IAutorServicio
    {
        private readonly IAutorRepositorio autorRepositorio;

        public AutorServicio(IAutorRepositorio autorRepositorio)
        {
            this.autorRepositorio = autorRepositorio;
        }

        public async Task<bool> CrearAsync(CrearAutorDto autor)
        {
            var entidad = new Autor
            {
                Nombre = autor.Nombre,
                Apellido = autor.Apellido
            };
            await autorRepositorio.CrearAsync(entidad);
            return true;
        }
        public async Task<bool> EliminarAsync(int id)
        {
            var consulta = autorRepositorio.ObtenerTodos();
            consulta = consulta.Where(c => c.Id == id);
            var autor = consulta.SingleOrDefault();

            await autorRepositorio.EliminarAsync(autor);
            return true;
        }
        public async Task<ICollection<AutorDto>> ObtenerTodosAsync()
        {
            var consulta = autorRepositorio.ObtenerTodos();
            var ListaAutors = await consulta.Select(x => new AutorDto
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Apellido=x.Apellido
              
            }).ToListAsync();

            return ListaAutors;
        }
        public async Task<AutorDto> ObtenerIdAsync(int id)
        {
            var consulta = autorRepositorio.ObtenerTodos();
            consulta = consulta.Where(c => c.Id == id);
            var ListaAutors = await consulta.Select(x => new AutorDto
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Apellido = x.Apellido
            }).SingleOrDefaultAsync();

            return ListaAutors;
        }
        public async Task<bool> ActualizarAsync(int id, CrearAutorDto autorDto)
        {
            var consulta = autorRepositorio.ObtenerTodos();
            consulta = consulta.Where(c => c.Id == id);
            var autor = consulta.SingleOrDefault();
            autor.Nombre = autorDto.Nombre;
            autor.Apellido = autorDto.Apellido;
         

            await autorRepositorio.ActualizarAsync(autor);
            return true;

        }

        
       

        

      
    }
}
