using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;  /*Usado para o List*/
using System.Linq;
using System.Threading.Tasks;
using VendasMvc.Models; /*Acrescentar para reconhecer o Department*/
namespace VendasMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index() /*Criar a View com o mesmo  nome para ele casar a ação com a View*/
        {
            List<Department> list = new List<Department>(); /*Vamos dar o nome de list e instanciar o Department*/
            list.Add(new Department { Id = 1, Name = "Eletronicos" });
            list.Add(new Department { Id = 2, Name = "Hidráulico" });

            return View(list); /*Enviar a lista com os dados para a View - ou seja enviar dados do controller para a view*/
        }
    }
}
