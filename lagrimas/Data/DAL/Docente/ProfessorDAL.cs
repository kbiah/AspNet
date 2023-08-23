using Modelo.Docente;
using System.Linq;
using lagrimas.Areas;

namespace lagrimas.Data.DAL.Docente
{
    public class ProfessorDAL
    {
        private IESContext _context;

        public ProfessorDAL(IESContext context)
        {
            _context = context;
        }

        public IQueryable<Professor> ObterProfessoresClassificadosPorNome()
        {
            return _context.Professores.OrderBy(b => b.Nome);
        }
    }
}