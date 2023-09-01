using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo.Discente
{
    public class Academico
    {
        [DisplayName("Código")]
        public long? AcademicoID { get; set; }

        [StringLength(10, MinimumLength = 10)]
        [RegularExpression("([0-9]{10})")]
        [Required(ErrorMessage = "Preencha esse campo!")]
        [DisplayName("Número do Registro")]
        public string RegistroAcademico { get; set; }

        [Required(ErrorMessage = "Preencha esse campo!")]
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        [Required(ErrorMessage = "Preencha esse campo!")]
        public DateTime? Nascimento { get; set; }
        public string FotoMimeType { get; set; }
        public byte[] Foto { get; set; }

        [NotMapped]
        public Microsoft.AspNetCore.Http.IFormFile formFile { get; set; }
    }
}