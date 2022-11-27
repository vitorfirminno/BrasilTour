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
        public IActionResult MinasGerais() {


            return View();
        }

        public IActionResult Acre() {


            return View();
        }

        public IActionResult Alagoas() {


            return View();
        }

        public IActionResult Amapa() {


            return View();
        }

        public IActionResult Amazonas() {


            return View();
        }
        public IActionResult Bahia() {

            return View();
        }


        public IActionResult Ceara() {


            return View();
        }


        public IActionResult DistritoFederal() {


            return View();
        }


        public IActionResult EspiritoSanto() {


            return View();
        }

        public IActionResult Goias() {


            return View();
        }

        public IActionResult Maranhão() {


            return View();
        }

        public IActionResult MatoGrosso() {


            return View();
        }

        public IActionResult MatoGrossodoSul() {


            return View();
        }


        public IActionResult Para() {


            return View();
        }


        public IActionResult Paraiba() {


            return View();
        }

        public IActionResult Pernambuco() {


            return View();
        }

        public IActionResult Piaui() {


            return View();
        }

        public IActionResult RioGrandedoNorte() {


            return View();
        }
        public IActionResult RioGrandedoSul() {


            return View();
        }


        public IActionResult Roraima() {


            return View();
        }
        public IActionResult SantaCatarina() {


            return View();
        }
        public IActionResult Sergipe() {


            return View();
        }
        public IActionResult Tocantins() {


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


