using Microsoft.AspNetCore.Mvc;

namespace Primeiro_APP.Controllers
{
    public class AlunoController : Controller
    {
        [ViewData] public string nome { get; set; }        
        [ViewData] public string sobrenome { get; set; }
        
        public IActionResult Index()
        {
            ViewBag.nota = "Aluno nota 10";
            ViewData["Escola"] = "Escola Pedro Fonseca";

            nome = "Nilson";
            sobrenome = "Alcides";      

            return View();
        }

        public IActionResult Teste()
        {
            TempData["MSG_EX"] = "Mensagem do TempData";
            return RedirectToAction("Resultado");
        }
        public IActionResult Resultado() 
        {
            if (TempData["MSG_EX"] != null)
                ViewBag.Exemplo = "Alunos do 3°B";            
            return View();
        }
       public IActionResult Redireciomaneto()
        {
            return Redirect("https://www.google.com/");
        } 

        public IActionResult RedireciomanetoToRota()
        {
            return RedirectToRoute(new { Controller = "Aluno", Action = "Resultado" });
        }
        public IActionResult RedireciomanetoPorAction()
        {
            return RedirectToAction("Resultado", "Aluno");
        }

    }
}
