using BrasilTour.Models;
using BrasilTour.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Diagnostics;

namespace BrasilTour.Controllers {
    public class EstadosController : Controller {

        private readonly IEstadoRepositorio _estadoRepositorio;
        public EstadosController(IEstadoRepositorio estadoRepositorio) {
            _estadoRepositorio = estadoRepositorio;
        }
        public IActionResult Index() {



        return View();
            }






        public IActionResult Forms() {
            /*Criar*/


            return View();
        }
        [HttpPost]
        public IActionResult Forms(EstadosModel estados) {
            /*Criar*/
            _estadoRepositorio.Adicionar(estados);
            return RedirectToAction("Index");

            return View();
        }







            public IActionResult RioDeJaneiro() {


            return View();
        }


        public IActionResult Rondonia() {


            return View();
        }

        public IActionResult SãoPaulo() {



            return View();
        }
        public IActionResult Exemplo() {
            List<EstadosModel> estados = _estadoRepositorio.BuscarTodos();

            return View(estados);
        }



        public IActionResult Privacy() {
                return View();
            }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error() {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }

        public IActionResult Comentarios() {
            List<EstadosModel>  estados = _estadoRepositorio.BuscarTodos();

            return View(estados);
        }
    }
    }


