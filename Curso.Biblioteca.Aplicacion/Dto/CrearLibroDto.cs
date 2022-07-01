using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Aplicacion.Dto
{
    public class CrearLibroDto
    {

        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public int AutorId { get; set; }
        public int EditorialId { get; set; }
    }
}
