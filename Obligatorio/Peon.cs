using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    public class Peon:Empleado //Herencia 
    {
        //Atributos 
        public bool residenteInstancia { get; set; }

        private List<Tarea> _tareas = new List<Tarea>();


        //******METODOS******

        public List<Tarea> MisTAreas() { return _tareas; }

        //Asignar tareas
        public void AsignarTarea(Tarea t)
        {
            _tareas.Add(t);
        }
            
        
        //Devolver una lista de tareas
        public List<Tarea> GetTareas()
        {
            return _tareas;
        }

        //Agregar Tarea
        public void AgregarTarea(Tarea t)
        {
                
                _tareas.Add(t);
        }

        //Constructor
        public Peon():base() 
        { 
        
        
        }
        //Constructor con parametros
        public Peon(string mail, string contraseña, string nombre, DateTime fechaIngreso, string tipo, bool residenteInstancia) : base(mail, contraseña, nombre, fechaIngreso, tipo)
        {
            this.residenteInstancia = residenteInstancia;
        }


        public void ValidarTarea(Tarea t)
        {
            if(t.Descripcion == null )
            {
                throw new Exception("Datos invalidos en tarea ,peon");

            }


            DateTime fecha = new DateTime(1980, 2, 2); 
            if (t.FechaCierre < fecha)
            {
                throw new Exception("Fecha mal ingresada ,peon");
            }
        }



        // valida los datos de empleado
        public override void EsValido()
        {
            base.EsValido();
            if(residenteInstancia != false && residenteInstancia !=true)
            {
                throw new Exception("invalido peon");
            }

            DateTime fechaLimite = new DateTime(1990, 2, 2);

            if (fechaIngreso <= fechaLimite)
            {
                throw new Exception("La fecha de ingreso debe ser posterior al 2 de febrero de 1990.");
            }

        }
    }
}
