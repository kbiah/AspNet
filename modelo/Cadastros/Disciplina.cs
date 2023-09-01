using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Modelo.Cadastros
{
    public class Disciplina
    {
        [DisplayName("Código")]
        public long? DisciplinaID { get; set; }

        [Required(ErrorMessage = "Preencha o nome!")]
        public string Nome { get; set; }

        public virtual ICollection<CursoDisciplina> CursosDisciplinas { get; set; }
    }
}
