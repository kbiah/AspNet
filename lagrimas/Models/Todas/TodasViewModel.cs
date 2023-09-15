using System.Collections.Generic;

namespace lagrimas.Models.Todas
{
    public class TodasViewModel
    {
        public lagrimas.Models.Dashboard.DashboardModel DashboardModel { get; set; }

        public IEnumerable<Modelo.Cadastros.Departamento> DepartamentoIndex { get; set; }
        public Modelo.Cadastros.Departamento DepartamentoModel { get; set; }

        public Modelo.Cadastros.Instituicao InstituicaoModel { get; set; }
        public IEnumerable<Modelo.Cadastros.Instituicao> InstituicaoIndex { get; set; }

    }
}
