using Microsoft.AspNetCore.Mvc;
using Obligatorio;

namespace WebAppObligatorio.Controllers
{
    public class VacunaController : Controller
    {

        Sistema s = Sistema.GetInstancia();

        public IActionResult Index()
        {
            return View();
        }







        /*Mostrar vacunas*/



    }
}
