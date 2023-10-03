using Livra.Models;
using System.Web.Mvc;

namespace Livraria.Controllers
{
    public class HomeController : Controller
    {

     
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Privacy()
        {
            return View();
        }

   

        public ActionResult Cadastro()
        {

            {
                var livrosModel = new LivrosModel();
                return View(livrosModel);

            };

        }

        [HttpPost]
        public ActionResult Cadastro(LivrosModel livrosModel)
        {
            if (!ModelState.IsValid)

            {
                return View(livrosModel);
            }
            return View("Lista", livrosModel);
        }

        public ActionResult Lista(LivrosModel livrosModel)
        {
            return View(livrosModel);
        }

    }

}
