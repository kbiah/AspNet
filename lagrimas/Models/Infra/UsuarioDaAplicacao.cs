 using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;
using System.Xml.Linq;

namespace lagrimas.Models.Infra
{

    [Table("AspNetUsers")]
    public class UsuarioDaAplicacao : IdentityUser
        {
        }
}
