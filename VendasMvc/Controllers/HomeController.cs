using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VendasMvc.Models.ViewModels;

namespace VendasMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
            /*Métodos que vão nos auxiliar a instancioar o objeto de resposta. 
            ex: View, NotFound, Redirect (Usar o CRTL + espaço depois ir na opção métodos.)*/
        }

        public IActionResult Privacy()
        {
            /*Passagem de dados entre o controlador e a View*/
            ViewData["Message"] = "Aula de MVC";
            ViewData["Professor"] = "juliano M. Lima";
            ViewData["email"]   = "juliano.lima@docente.unip.br";
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
