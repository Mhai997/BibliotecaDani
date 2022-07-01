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
    public class AutorRepositorio : IAutorRepositorio
    {
        private readonly BibliotecaDbContext context;

        public AutorRepositorio(BibliotecaDbContext context)
        {
            this.context = context;
        }

        public async Task ActualizarAsync(Autor autor)
        {
            context.Update(autor);
            await context.SaveChangesAsync();
        }

        public async Task CrearAsync(Autor autor)
        {
            await context.AddAsync(autor);
            await context.SaveChangesAsync();
        }

        public async Task EliminarAsync(Autor autor)
        {
            context.Remove(autor);
            await context.SaveChangesAsync();
        }

        public IQueryable<Autor> ObtenerTodos()
        {
            return context.Autores.AsQueryable();
        }
    }
}
