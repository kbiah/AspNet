using Modelo.Cadastros;
using Modelo.Docente;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Modelo.Cadastros
{
    public class Curso
    {
        [DisplayName("Código do Curso")]
        public long? CursoID { get; set; }

        [Required(ErrorMessage = "Preencha o nome!")]
        public string Nome { get; set; }

        [DisplayName("Código do departamento")]
        public long? DepartamentoID { get; set; }
        public Departamento Departamento { get; set; }

        public virtual ICollection<CursoDisciplina> CursosDisciplinas { get; set; }
        public virtual ICollection<CursoProfessor> CursosProfessores { get; set; }
    }
}