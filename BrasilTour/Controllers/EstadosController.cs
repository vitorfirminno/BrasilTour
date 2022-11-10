using BrasilTour.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System.Diagnostics;

namespace BrasilTour.Controllers {
    public class EstadosController : Controller {
       

            public IActionResult Index() {


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


        public IActionResult Privacy() {
                return View();
            }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error() {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }


