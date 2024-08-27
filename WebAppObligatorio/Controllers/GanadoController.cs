using Microsoft.AspNetCore.Mvc;
using Obligatorio;

namespace WebAppObligatorio.Controllers
{
    public class GanadoController : Controller
    {
        Sistema s = Sistema.GetInstancia();

        public IActionResult Index()
        {
            return View();
        }


        /*************************************************************************************/
        /*******************************     PEON       **************************************/
        /*************************************************************************************/


        /*Listar ganado*/
        public IActionResult ListarGanado()
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Peon")
            {
                List<Ganado> g = s.GetGanados();
                return View(g);

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
                
        }





        /**** Registrar vacunacion ****/

       
        public IActionResult AsignarVacuna(int idGanado)
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Peon")
            {

                ViewBag.IdGanado = idGanado;
                ViewBag.Vacunas = s.GetVacunas();
                return View();

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }


        }

        [HttpPost]
        public IActionResult AsignarVacuna(int idGanado, DateTime fecha , int idV)
        {

           

            try
            {
                Vacuna buscadaVacuna = s.BuscarVacunaXId(idV);
                Ganado buscadoGanado = s.BuscarGanadoXId(idGanado);

                s.AsignarVacunaAnimal(buscadoGanado,  fecha, buscadaVacuna);
                ViewBag.msg = "Alta realizada";

            }
            catch (Exception e)
            {
                ViewBag.msg = "Error" + e.Message;
            }

            ViewBag.IdGanado = idGanado;
            ViewBag.Vacunas = s.GetVacunas();
            //Debo tener los viewbag aqui tambien 
            return View();


        }

        /*************************************************************************************/
        /*******************************     CAPATAZ       **************************************/
        /*************************************************************************************/

        /*Registro bovino*/

        public IActionResult RegistroBovino()
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Capataz")
            {

                ViewBag.sexo = new List<string> { "macho", "hembra" };
                return View();
            }

            else
            {
                return RedirectToAction("Index", "Home");
            }

           
        }
        [HttpPost]
        public IActionResult RegistroBovino(Bovino g)
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Capataz")
            {

                try
                {

                    s.AltaGanado(g);
                    ViewBag.msg = "Alta realizada";
                }
                catch (Exception e)
                {
                    ViewBag.msg = "Error" + e.Message;
                }
               

                  

                
                    
              
                ViewBag.sexo = new List<string> { "macho", "hembra" };
                return View();



            }

            else
            {
                return RedirectToAction("Index", "Home");
            }
            
           

        }



        /************************Asignar ganado al potrero ********************** */
        public IActionResult AsignarPotrero(int idGanado)
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Capataz")
            {

                ViewBag.IdGanado = idGanado;
                ViewBag.Potrero = s.GetPotreros();
                return View();


            }

            else
            {
                return RedirectToAction("Index", "Home");
            }
           
        }

        [HttpPost]
        public IActionResult AsignarPotrero(int idGanado, int PotreroId)
        {

            if (HttpContext.Session.GetString("logueadoRol") == "Capataz")
            {

                try
                {
                    Potrero buscarPotrero = s.BuscarPotreroXId(PotreroId);
                    Ganado buscadoGanado = s.BuscarGanadoXId(idGanado);

                    if (s.GanadoLibre(buscadoGanado) == true)
                    {
                        s.AsignarGanadoLibre(buscadoGanado, buscarPotrero);
                        ViewBag.msg = "Alta realizada";
                    }
                    else
                    {
                        ViewBag.msg = "Ya tiene potrero";

                    }




                }
                catch (Exception e)
                {
                    ViewBag.msg = "Error" + e.Message;
                }

                ViewBag.IdGanado = idGanado;
                ViewBag.Potrero = s.GetPotreros();
                //Debo tener los viewbag aqui tambien 
                return View();


            }

            else
            {
                return RedirectToAction("Index", "Home");
            }

         


        }

        public IActionResult ListarGanadoPotrero()
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Capataz")
            {
                List<Ganado> g = s.GetGanados();
                return View(g);

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
                
        }

        /************************* Animales con un peso dado (el ultimo ) ******************/

        public IActionResult BuscarGanado()
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Capataz")
            {
                List<Ganado> g = s.GetGanados();
                return View(g);

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }
        [HttpPost]

        public IActionResult BuscarGanado(int peso,string tipo)
        {

            try
            {




                List<Ganado> ga = s.BuscarXPesoYTipo(peso, tipo);
                return View(ga);


            }
            catch (Exception ex) 
            {
                List<Ganado> vacia = new List<Ganado>();
            ViewBag.msg=ex.Message;
                return View(vacia);
            
            }


           





        }












    }
}
