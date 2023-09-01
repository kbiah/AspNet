using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Modelo.Cadastros
{
    public class CursoDisciplina
    {
        [DisplayName("Código do Curso")]
        public long? CursoID { get; set; }

        public Curso Curso { get; set; }

        [DisplayName("Código da disciplina")]
        public long? DisciplinaID { get; set; }

        public Disciplina Disciplina { get; set; }
    }
}