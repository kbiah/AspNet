
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Cadastros
{
    public class Instituicao
    {
        [DisplayName("Código da Instituição")]
        public long? InstituicaoID { get; set; }

        [Required(ErrorMessage = "Preencha o nome!")]
        [DisplayName("Nome da Instituição")]
        public string Nome { get; set; }

        [DisplayName("Endereço")]
        [Required(ErrorMessage ="Preencha o endereço!")]
        public string Endereco { get; set; }
        public virtual ICollection<Departamento> Departamentos { get; set; }

    }
}
