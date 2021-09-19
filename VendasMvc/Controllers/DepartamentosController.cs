using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic; /*Usado para o List*/
using System.Linq;
using System.Threading.Tasks;
using VendasMvc.Models; /*Reconhecer o Departamento*/

namespace VendasMvc.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()  /*Criar a view com o mesmo nome para casar a ação*/
        {
            List<Departamento> list = new List<Departamento>(); /*Dar o nome de List e instanciar Departamento*/
            list.Add(new Departamento { Id = 1, Name = "Eletronico" });
            list.Add(new Departamento { Id = 2, Name = "Hidraulico" });

            return View(list); /*Enviar os dados da lista para a View- dados do controller para a view*/
        }
    }
}
