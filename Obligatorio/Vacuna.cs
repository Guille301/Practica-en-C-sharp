using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    public class Vacuna
    {
        //Atributos 
        public int Id { get; set; }

        public static int UltimoID { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }

        public string patogeno { get; set; }

        //Constructor 
        public Vacuna()
        {
            Id = UltimoID++;
        }

        //Constructor con Parametros
        public Vacuna(string nombre, string descripcion, string patogeno)
        {
            Id = UltimoID++;

            this.nombre = nombre;
            this.descripcion = descripcion;
            this.patogeno = patogeno;
        }



        //Validacion 
        public void EsValido()
        {
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(patogeno) )
            {

                throw new Exception("Datos mal ingresados en vacunas");


            }
        }



    }
}
