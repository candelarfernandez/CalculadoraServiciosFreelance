using CalculadorFreelance.Entidades;
using CalculadorFreelance.Models;
using CalculadorFreelance.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CalculadorFreelance.Controllers
{
    public class CalculadorController : Controller
    {
        private IServiceCalculador _serviceCalculador;

        public CalculadorController(IServiceCalculador serviceCalculador)
        {
            _serviceCalculador=serviceCalculador;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Calcular()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Calcular(CalculadorModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var calculador = new Calculador
            {
                nombre = model.nombre,
                horas = model.horas,
                valorHora = model.valorHora
            };
            _serviceCalculador.Calcular(calculador);

            return RedirectToAction("Resultados");
        }
        [HttpGet]
        public IActionResult Resultados()
        {
             var lista = _serviceCalculador.ObtenerResultados();
             var listaCalculadorModels = lista.Select(calculador => new CalculadorModel(calculador)).ToList();
            return View(listaCalculadorModels);
        }


    }
}
