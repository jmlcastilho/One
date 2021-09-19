using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasMvc.Models;

namespace VendasMvc.Controllers
{
    public class TestesController : Controller
    {
        public IActionResult Index()
        {
            List<Teste> list = new List<Teste>();
            list.Add(new Teste { Id = 1, Name = "Elemento 1" });
            list.Add(new Teste { Id = 2, Name = "Elemento 2" });
            return View(list);
        }
    }
}
