using Curso.Biblioteca.Dominio.Entidades;
using Curso.Biblioteca.Dominio.IRepositorios;
using Curso.Biblioteca.Infraestructura.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Infraestructura.RepositoriosImplementacion
{
    public class LibroRepositorio : ILibroRepositorio
    {
        private readonly BibliotecaDbContext context;

        public LibroRepositorio(BibliotecaDbContext context)
        {
            this.context = context;
        }

        public async Task ActualizarAsync(Libro libro)
        {
            context.Update(libro);
            await context.SaveChangesAsync();
        }

        public async Task CrearAsync(Libro libro)
        {
            await context.AddAsync(libro);
            await context.SaveChangesAsync();
        }

        public async Task EliminarAsync(Libro libro)
        {
            context.Remove(libro);
            await context.SaveChangesAsync();
        }

        public IQueryable<Libro> ObtenerTodos()
        {
            return context.Libros.AsQueryable();
        }
    }
}
