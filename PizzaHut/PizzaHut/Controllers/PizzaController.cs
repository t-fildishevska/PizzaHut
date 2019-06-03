using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PizzaHut.Controllers
{
    //[Route("Pica")]
    public class PizzaController : Controller
    {
        //[Route("MyPizza")]
        public IActionResult Index()
        {
            ViewBag.Name = "brain.OutOf(Ideas)";
            ViewData["message"] = "All the viewDatas!!!";
            return View();
        }
    }
}