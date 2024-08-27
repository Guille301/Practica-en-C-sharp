using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    public class Tarea : IComparable<Tarea>
    {
        //Atributos
        public int Id { get; set; }
        public static int UltimoID { get; set; }

        public string Descripcion { get; set; }
        public DateTime FechaDeRealizacion { get; set; }

        public bool SiSeCompleto { get; set; }

        public DateTime FechaCierre { get; set; }

        public string ComentarioPeon { get; set; }


        //Constructor
        public Tarea()
        {
            Id = UltimoID++;
        }
        //Constructor con parametros
        public Tarea(string descripcion, DateTime fechaDeRealizacion, bool siSeCompleto, DateTime fechaCierre, string comentarioPeon)
        {
            Id = UltimoID++; 

            Descripcion = descripcion;
            FechaDeRealizacion = fechaDeRealizacion;
            SiSeCompleto = siSeCompleto;
            FechaCierre = fechaCierre;
            ComentarioPeon = comentarioPeon;
        }


        public int CompareTo(Tarea other)
        {

            if (FechaCierre.CompareTo(other.FechaCierre) > 0)
            {
                return 1;
            }
            else if (FechaCierre.CompareTo(other.FechaCierre) < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }


        }



    }
}
