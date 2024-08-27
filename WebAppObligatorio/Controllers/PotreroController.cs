using Microsoft.AspNetCore.Mvc;
using Obligatorio;

namespace WebAppObligatorio.Controllers
{
    public class PotreroController : Controller
    {
        Sistema s = Sistema.GetInstancia();

        public IActionResult Index()
        {
            return View();
        }



        public IActionResult PotrerosOrdenados()
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Capataz")
            {
                List<Potrero> listaPotreros = s.GetPotreros();
                listaPotreros.Sort();
                return View(listaPotreros);

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }


























    }
}
