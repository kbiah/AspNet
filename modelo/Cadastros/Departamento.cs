using Modelo.Cadastros;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Modelo.Cadastros
{
    public class Departamento
    {
        [DisplayName("Código do Departamento")]
        public long? DepartamentoID { get; set; }// long? que aceita valor nulo

        [Required(ErrorMessage = "Preencha o nome!")]
        [DisplayName("Nome do Departamento")]
        public string Nome { get; set; }

        [DisplayName("Código da Instituição")]
        public long? InstituicaoID { get; set; }

        [Required(ErrorMessage = "Preencha a Instituição!")]
        [DisplayName("Nome da Instituição")]
        public Instituicao Instituicao { get; set; }

        public virtual ICollection<Curso> Cursos { get; set; }
    }
}