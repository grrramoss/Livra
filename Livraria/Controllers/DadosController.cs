using Livra.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Livra.Controllers
{
    public class DadosController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        private readonly IEnumerable<LivrosModel> todososLivros;

        public DadosController()
        {
            todososLivros = new LivrosModel().TodosOsLivros().OrderByDescending(x => x.Data);
        }

        public ActionResult Livro()
        {
            var todosLivros = todososLivros;
            var todososGeneros = todososLivros.Select(x => x.Genero).Distinct().ToList();

            ViewBag.Generos = todososGeneros;

            return View(todosLivros);


        }


        public ActionResult TodosLivros()
        {
            return View(todososLivros);

        }


        public ActionResult MostrarGenero(string genero)
        {
            var GeneroEspecifico = todososLivros.Where(x => x.Genero.ToLower() == genero.ToLower()).ToList();
            ViewBag.Genero = genero;

            return View(GeneroEspecifico);
        }
    }


}

