using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    public class Potrero : IComparable<Potrero>
    {
        //Atributos 
        public int id { get; set; }

        public static int ultimoId { get; set; } = 1;

        public string descripcion { get; set; }

        public int cantidadHectareas { get; set; }

        public int capacidadMaximaAnimales { get; set; }

        private List<Ganado> _animales = new List<Ganado>();


        //Obtener listado de animales
        public List<Ganado> GetGanado()
        {
            return _animales;
        }


        public int GanadoPotrero()
        {
            int ret = _animales.Count;
            return ret;
        }

        //Agregar Animal al Potrero
        public bool AgregarAnimalAlPotrero(Ganado g) {

            if (capacidadMaximaAnimales > _animales.Count)
            {
                _animales.Add(g);
                return true;


            }
            return false;

            
            
            
        
        }

        


        //Constructor
        public Potrero()
        {
            id = ultimoId++;
        }

        
        //Constructor con parametros
        public Potrero(string descripcion, int cantidadHectareas, int capacidadMaximaAnimales)
        {
            id = ultimoId++;
            this.descripcion = descripcion;
            this.cantidadHectareas = cantidadHectareas;
            this.capacidadMaximaAnimales = capacidadMaximaAnimales;
        }




        //****METODOS****

        //Validacion

        public void EsValido()
        {
            if (string.IsNullOrEmpty(descripcion) ||capacidadMaximaAnimales==null || cantidadHectareas==null)
            {
                throw new Exception("Datos invalidos potreros");
            }
        }

        //Metodo Animal es libre
        public bool AnimalEsLibre(Ganado ga)
        {
            foreach(Ganado g in _animales)
            {
                if(g.id == ga.id)
                {
                    return true;
                }

            }
            return false;

        }

        //toString de la clase
        public override string ToString()
        {
            return $"Descripcion:{descripcion} || Cantidad de Hectareas:{cantidadHectareas} || Capacidad Maxima: {capacidadMaximaAnimales} || ID: {id}";

        }


        
      

        public double GananciaPotrero()
        {
            List<Ganado> listaGanado = GetGanado();

            double PrecioFinal = 0;
            foreach (Ganado ganado in listaGanado)
            {
                PrecioFinal += ganado.CalcularGanado() ;
            }

            return PrecioFinal;
        }







       

        

        //Metodo CompareTo
        public int CompareTo(Potrero? other)
        {
            if (this.capacidadMaximaAnimales.CompareTo(other.capacidadMaximaAnimales) == 0)
            {
                return this._animales.Count().CompareTo(other._animales.Count()) * -1;
            }
            else
            {
                return this.capacidadMaximaAnimales.CompareTo(other.capacidadMaximaAnimales);
            }
        }

        






    }
}
