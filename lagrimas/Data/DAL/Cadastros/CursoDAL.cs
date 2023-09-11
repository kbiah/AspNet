using Modelo.Cadastros;
using Modelo.Docente;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace lagrimas.Data.DAL.Cadastros
{
    public class CursoDAL
    {
        private IESContext _context;

        public CursoDAL(IESContext context)
        {
            _context = context;
        }

            public void RegistrarProfessor(long cursoID, long professorID)
            {
                var curso = _context.Cursos.Where(c => c.CursoID == cursoID).Include(cp => cp.CursosProfessores).First();
                var professor = _context.Professores.Find(professorID);
                curso.CursosProfessores.Add(new CursoProfessor() { Curso = curso, Professor = professor });
                _context.SaveChanges();
            }

            public IQueryable<Curso> ObterCursosPorDepartamento(long departamentoID)
            {
                var cursos = _context.Cursos.Where(c => c.DepartamentoID == departamentoID).OrderBy(d => d.Nome);
                return cursos;
            }

            public IQueryable<Professor> ObterProfessoresForaDoCurso(long cursoID)
            {
                var curso = _context.Cursos.Where(c => c.CursoID == cursoID).Include(cp => cp.CursosProfessores).First();
                var professoresDoCurso = curso.CursosProfessores.Select(cp => cp.ProfessorID).ToArray();
                var professoresForaDoCurso = _context.Professores.Where(p => !professoresDoCurso.Contains(p.ProfessorID));
                return professoresForaDoCurso;
            }
        }
    }

    //public void RegistrarProfessor(long cursoID, long professorID)
    //{
    //    var curso = _context.Cursos.Where(c => c.CursoID == cursoID).Include(cp => cp.CursosProfessores).First();
    //    var professor = _context.Professores.Find(professorID);
    //    curso.CursosProfessores.Add(new CursoProfessor() { Curso = curso, Professor = professor });
    //    _context.SaveChanges();
    //}

    //public IQueryable<Curso> ObterCursosPorDepartamento(long departamentoID)
    //{
    //    var cursos = _context.Cursos.Where(c => c.DepartamentoID == departamentoID).OrderBy(d => d.Nome);
    //    return cursos;
    //}

    //public IQueryable<Professor> ObterProfessoresForaDoCurso(long cursoID)
    //{
    //    var curso = _context.Cursos.Where(c => c.CursoID == cursoID).Include(cp => cp.CursosProfessores).First();
    //    var professoresDoCurso = curso.CursosProfessores.Select(cp => cp.ProfessorID).ToArray();
    //    var professoresForaDoCurso = _context.Professores.Where(p => !professoresDoCurso.Contains(p.ProfessorID));
    //    return professoresForaDoCurso;
    //}

    //public IQueryable<Curso> ObterCursosClassificadosPorNome()
    //{
    //    return _context.Cursos.OrderBy(b => b.Nome);
    //}

    //public async Task<Curso> ObterCursoPorId(long id)
    //{
    //    return await _context.Cursos.Include(d => d.Departamento).SingleOrDefaultAsync(m => m.CursoID == id);
    //}

    //public async Task<Curso> GravarCurso(Curso curso)
    //{
    //    if (curso.CursoID == null)
    //    {
    //        _context.Cursos.Add(curso);
    //    }
    //    else
    //    {
    //        _context.Update(curso);
    //    }
    //    await _context.SaveChangesAsync();
    //    return curso;
    //}

    //public async Task<Curso> EliminarCursoPorId(long id)
    //{
    //    Curso curso = await ObterCursoPorId(id);
    //    _context.Cursos.Remove(curso);
    //    await _context.SaveChangesAsync();
    //    return curso;
    //}