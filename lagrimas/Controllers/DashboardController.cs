using lagrimas.Data;
using lagrimas.Data.DAL.Cadastros;
using System.Linq;
using System;
using lagrimas.Data.DAL.Discente;
using Microsoft.AspNetCore.Mvc;
using Modelo.Cadastros;
using lagrimas.Models.Dashboard;
using System.Diagnostics.Metrics;
using Microsoft.EntityFrameworkCore;
using lagrimas.Data.DAL.Docente;
using Microsoft.AspNetCore.Authorization;

namespace lagrimas.Controllers
{ 
public class DashboardController : Controller
{

    private readonly IESContext _context;
    private readonly InstituicaoDAL instituicaoDAL;
    private readonly DepartamentoDAL departamentoDAL;
    private readonly ProfessorDAL professorDAL;

    public DashboardController(IESContext context)
    {
        _context = context;
        instituicaoDAL = new InstituicaoDAL(context);
        departamentoDAL = new DepartamentoDAL(context);
        professorDAL = new ProfessorDAL(context);
    }


    [HttpPost]
    public IActionResult ContarTudo()
    {
        var contagemInst = _context.Instituicoes.Count();
        var contagemDepart = _context.Departamentos.Count();

            var model = new DashboardModel
            {
                quantidade = contagemInst,
                quantidadeDepart = contagemDepart
            };

            // Retorna a contagem
            return PartialView("_DashboardView", model);
        }
            
    }}

