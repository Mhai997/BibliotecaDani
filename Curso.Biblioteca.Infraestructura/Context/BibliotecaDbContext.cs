using Curso.Biblioteca.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Infraestructura.Context
{
    public class BibliotecaDbContext : DbContext
    {
        public BibliotecaDbContext(DbContextOptions<BibliotecaDbContext> options) : base(options)
        {
        }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Editorial> Editoriales { get; set; }
        public DbSet<Libro> Libros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder constructor)
        {
            var conexion = @"Server=(localdb)\mssqllocaldb;Database=Biblioteca;Trusted_Connection=True";
            constructor.UseSqlServer(conexion);
        }
    }
}
