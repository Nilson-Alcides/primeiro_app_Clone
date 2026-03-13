using Microsoft.AspNetCore.Mvc;

namespace Primeiro_APP.Controllers
{
    public class ProfessorController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.nomeProf = "Nilson J. Alcides";
            ViewBag.curso = "Desenvolvimento de sistema";
            ViewBag.disciplina = "Programação Back-end";
            return View();
        }
    }
}
