using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    public class VacunacionAnimal
    {


        //Atributos

        public int id { get; set; }

        public static int ultimoId { get; set; } = 1;


        public DateTime FechaVacunacion { get; set; }


        public Vacuna vacuna {get; set;}

       

        


        


        //Constructor
        public VacunacionAnimal()
        {
            id = ultimoId++;
        }

        //Constructor con parametros
        public VacunacionAnimal(  DateTime fechaVacunacion, Vacuna vacuna )
        {
            FechaVacunacion = fechaVacunacion;
            this.vacuna = vacuna;
       
         
        }




        //Metodo Vencimiento de vacuna 1 anio despues
        public bool vencimientoDeVacuna1AnioDespues()
        {
            if(FechaVacunacion > FechaVacunacion.AddYears(1))
            {
                return true;
            }
            return false;
        }

        // Tostring de la clase
        public override string ToString()
        {
            return $"Fecha: {FechaVacunacion}   || Vacuna:{vacuna}";
        }
    }
}
