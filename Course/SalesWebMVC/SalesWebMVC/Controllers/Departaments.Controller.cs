using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class Departaments : Controller
    {
        public IActionResult Index()
        {
            List<Departament> list = new List<Departament>();
            list.Add(new Departament { Id = 1, Name = "Eletronics" });
            list.Add(new Departament { Id = 2, Name = "Eletronics" });

            return View(list);
        }
    }
}
