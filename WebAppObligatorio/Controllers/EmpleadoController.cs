using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Obligatorio;

namespace WebAppObligatorio.Controllers
{
    public class EmpleadoController : Controller
    {
        Sistema s = Sistema.GetInstancia();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Login(string email, string password)
        {



            Empleado buscado = s.Login(email, password);
            if(buscado != null)
            {
                HttpContext.Session.SetInt32("logueadoId", buscado.id);
                HttpContext.Session.SetString("logueadoNombre", buscado.nombre);
                HttpContext.Session.SetString("logueadoRol", buscado.GetType().Name);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.msg = "Datos incorrectos";
                return View();
            }



        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }


        /*************************************************************************************/
        /*******************************     PEON       **************************************/
        /*************************************************************************************/


        /***********Registro Peon*************/

        public IActionResult Alta()
        {
            return View();
        }
        //Primero necesito un get para 


        [HttpPost]
        public IActionResult Alta(Peon p)
        {
            try
            {
                s.AltaEmpleado(p);
                //Debo llamar al alta persona de Sistema
                ViewBag.msg = "Alta realizada";
            }
            catch (Exception i)
            {
                ViewBag.msg = "Error" + i.Message;
            }
            return View();
        }


      

  



        /*Datos personales*/

        public IActionResult DatosPeon()
        {

            if (HttpContext.Session.GetString("logueadoRol") == "Peon")
            {
                Empleado e = new Peon();
                if (s.BuscarEmpleadoPorId != null)
                {
                    e = s.BuscarEmpleadoPorId(HttpContext.Session.GetInt32("logueadoId"));

                }
                else
                {
                    ViewBag.msg = "Error";
                }
                return View(e);

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
           
        }

        /**********************PEON *********************/
        /*Mostar Tareas del Peon*/
        public IActionResult ListarTareasPeon()
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Peon")
            {
                List<Tarea> t = new List<Tarea>();
                Peon e = new Peon();
                if (s.BuscarPeonPorId != null)
                {
                    e = s.BuscarPeonPorId(HttpContext.Session.GetInt32("logueadoId"));
                    t = e.GetTareas();
                    t.Sort();


                    
                }
                else
                {
                    ViewBag.msg = "Error";
                }
                return View(t);

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

            



        }




        /* Completar tarea de peon  */
        public IActionResult TareaCompletada(int id)
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Peon")
            {
                ViewBag.IdTarea = id;

                s.GetIdTarea(id);
                return View();

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
             

        }

        [HttpPost]

        public IActionResult TareaCompletada(Tarea t)
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Peon")
            {
                try
                {
                    if (t != null)
                    {
                        s.TareaRealizada(t);
                        ViewBag.msg = "Cambio realizado";
                        return RedirectToAction("ListarTareasPeon", "Empleado");
                    }
                    else
                    {
                        ViewBag.msg = "Error: La tarea no se recibió correctamente.";
                    }
                }
                catch (Exception ex)
                {
                    // Captura cualquier excepción que pueda ocurrir al llamar a TareaRealizada
                    ViewBag.msg = $"Error al realizar la tarea: {ex.Message}";
                }

                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }








        /*************************************************************************************/
        /*******************************     CAPATAZ       **************************************/
        /*************************************************************************************/

        /*Mostar Tareas Por Peon*/
        public IActionResult ListarTareasPorPeon(int id)
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Capataz")
            {
                ViewBag.IdDetalle = id;
                List<Tarea> t = s.BuscarTarea(id);
                return View(t);

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }


        /*Listar*/
        public IActionResult ListarEmpleado()
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Capataz")
            {

                List<Empleado> e = s.SoloPeones();
                return View(e);

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }




        }

        /*************Asignar tarea al peon **************/


        public IActionResult AsignarTarea()
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Capataz")
            {

                List < Empleado > e = s.SoloPeones();
                return View(e);
                
                /*var peones = s.GetEmpleados().Where(e => e.tipo == "peon").ToList();
                return View(peones);*/

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }




        }

        public IActionResult AsignarTareaAPeon(int idPeon)
        {
            ViewBag.IdPeon = idPeon;

            var tarea = new Tarea();
           

            return View(tarea);
        }



        [HttpPost]
        public IActionResult AsignarTareaAPeon(int idPeon, Tarea tarea)
        {
            try
            {
                Peon BuscarPeon = s.BuscarPeonPorId(idPeon);

                s.AsignarTareaAlPeon(BuscarPeon , tarea);
                ViewBag.msg = "Tarea asignada";

            }
            catch (Exception e)
            {
                ViewBag.msg = "Error" + e.Message;
            }

            ViewBag.IdPeon = idPeon;
            //Debo tener los viewbag aqui tambien 
            return View();
        }















    }
}
