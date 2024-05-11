using CalculadorFreelance.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CalculadorFreelance.Controllers
{
    public class PrincipalController : Controller
    {
       
        public PrincipalController()
        {
           
        }

        public IActionResult BienvenidosArtificiales()
        {
            ViewBag.Message = "Bienvenid@ al sitio de evaluación Web 3 Servicios Freelance";
            return View();
        }

       
    }
}
