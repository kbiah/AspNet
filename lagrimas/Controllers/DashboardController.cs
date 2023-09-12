using lagrimas.Data;
using lagrimas.Data.DAL.Cadastros;
using System.Linq;
using System;
using lagrimas.Data.DAL.Discente;
using Microsoft.AspNetCore.Mvc;
using lagrimas.Models.Composite;
using Modelo.Cadastros;
using lagrimas.Models.Dashboard;

namespace lagrimas.Controllers
{
    public class DashboardController : Controller
    {

        private readonly InstituicaoDAL instituicaoDAL;
        private readonly DepartamentoDAL departamentoDAL;
        private readonly AcademicoDAL academicoDAL;


        private int ContarInstituicao(object id)
        {
            var contar = instituicaoDAL.ObterInstituicoesClassificadasPorNome().Count();
            return contar;
        }
        private int ContarDepartamento(object id)
        {
            var contar = departamentoDAL.ObterDepartamentosClassificadosPorNome().Count();
            return contar;
        }

        private int ContarAcademico(object id)
        {
            var contar = academicoDAL.ObterAcademicosClassificadosPorNome().Count();
            return contar;
        }

        public IActionResult Dashboard(object id)
        {
            var viewModel = new DashboardModel
            {
                InstituicoesCount = ContarInstituicao(id),
                DepartamentosCount = ContarDepartamento(id),

            };

            return PartialView("_DashboardView", viewModel);
        }

    }
}
