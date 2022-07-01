using Curso.Biblioteca.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Aplicacion.Dto
{
    public class LibroDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string ISBN { get; set; }

        public string Autor { get; set; }

        public string Editorial { get; set; }
    }
}
