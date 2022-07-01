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
    public class EditorialRepositorio : IEditorialRepositorio
    {
        private readonly BibliotecaDbContext context;

        public EditorialRepositorio(BibliotecaDbContext context)
        {
            this.context = context;
        }

        public async Task ActualizarAsync(Editorial editorial)
        {
            context.Update(editorial);
            await context.SaveChangesAsync();
        }

        public async Task CrearAsync(Editorial editorial)
        {
            await context.AddAsync(editorial);
            await context.SaveChangesAsync();
        }

        public async Task EliminarAsync(Editorial editorial)
        {
            context.Remove(editorial);
            await context.SaveChangesAsync();
        }

        public IQueryable<Editorial> ObtenerTodos()
        {
            return context.Editoriales.AsQueryable();
        }
    }
}
