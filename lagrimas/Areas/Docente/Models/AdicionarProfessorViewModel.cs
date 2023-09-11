using Microsoft.Build.Framework;
using System.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace lagrimas.Areas.Docente.Models
{
    public class AdicionarProfessorViewModel
    {
        [DisplayName("Código da Instituição")]
        public long? InstituicaoID { get; set; }

        [DisplayName("Código do Departamento")]
        public long? DepartamentoID { get; set; }

        [DisplayName("Código do Curso")]
        public long? Nome { get; set; }

        [DisplayName("Código do Professor")]
        public long? ProfessorID { get; set; }
        public long CursoID { get; internal set; }
    }
}