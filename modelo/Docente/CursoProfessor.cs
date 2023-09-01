using Modelo.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Docente
{
    public class CursoProfessor
    {
        [DisplayName("Código do curso")]
        public long? CursoID { get; set; }

        public Curso Curso { get; set; }

        [DisplayName("Código do professor")]
        public long? ProfessorID { get; set; }

        public Professor Professor { get; set; }
    }
}
