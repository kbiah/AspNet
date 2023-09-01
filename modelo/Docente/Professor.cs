using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Docente
{
    public class Professor
    {
        [DisplayName("Código do Professor")]
        public long? ProfessorID { get; set; }

        [Required(ErrorMessage = "Preencha o nome!")]
        public string Nome { get; set; }

        public virtual ICollection<CursoProfessor> CursosProfessores { get; set; }
    }
}
