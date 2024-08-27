using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Obligatorio
{
    public abstract class Ganado
    {

        //Atributos 
        public int id { get; set; }

        public static int ultimoId { get; set; } = 1;

        public string codigoIdentificadorCaravana { get; set; }

        public   Enumerado_Genero sexo { get; set; }
        public string raza { get; set; }

        public DateTime fechaNacimiento { get; set; }

        public double costoAdquisicion { get; set; }

        public double costoAlimentacion { get; set; }

        public double pesoActual { get; set; }

        public bool hibrido { get; set; }

        private List<VacunacionAnimal> _vacunacionAnimal = new List<VacunacionAnimal>();



        //Metodo para Agregar Vacunacion Animal
        public void AgregarVacunacionAnimal(VacunacionAnimal v)
        {
             
            _vacunacionAnimal.Add(v);        

        }

        //Obtener lista de Animales Vacunados
        public List<VacunacionAnimal> GetVacunacionAnimal()
        {
            return _vacunacionAnimal;
        }


        //Constructor por defecto
        public Ganado()
        {
            id = ultimoId++;
        }

        //Constructor con parametros
        protected Ganado(string codigoIdentificadorCaravana, Enumerado_Genero sexo, string raza, DateTime fechaNacimiento, double costoAdquisicion, double costoAlimentacion, double pesoActual, bool hibrido)
        {
            id = ultimoId++;
            this.codigoIdentificadorCaravana = codigoIdentificadorCaravana;
            this.sexo = sexo;
            this.raza = raza;
            this.fechaNacimiento = fechaNacimiento;
            this.costoAdquisicion = costoAdquisicion;
            this.costoAlimentacion = costoAlimentacion;
            this.pesoActual = pesoActual;
            this.hibrido = hibrido;
        }



        //******METODOS******


        /*No puede Vacunarse Antes de los 3 meses de Edad*/
        public bool noPuedeVacunarseAntesDe3MesesDeEdad()
        {
            DateTime fecha3Meses = fechaNacimiento.AddMonths(3);
            return DateTime.Today < fecha3Meses;
        }


        //Asignar Vacunacion Animal
        public bool AsignarVacunacionAnimal(DateTime fechaVacunacion, Vacuna va)
        {


            if (noPuedeVacunarseAntesDe3MesesDeEdad() == false)
            {
                VacunacionAnimal vs = new VacunacionAnimal(fechaVacunacion, va);
                _vacunacionAnimal.Add(vs);
                return true;

            }


            return false;


        }

        public void ValidacionVacuna(DateTime fecha)
        {
            if (noPuedeVacunarseAntesDe3MesesDeEdad() == true)
            {
                throw new Exception("No puede vacunarse con esa edad");

            }

            if (fecha < fechaNacimiento)
            {
                throw new Exception("No tiene logica esa fecha");

            }
        }


        //Asignar Vacunacion Animal







        /**Validaciones**/


        //Metodo Es Alfanumerico
        public bool EsAlfanumerico(string input)
        {
           
            
           Regex regex = new Regex("^[a-zA-Z0-9]+$"); //Esto es útil para validar si el  texto cumple con un  formato específico en este caso AlfaNumerico

            return regex.IsMatch(input); //el método IsMatch del objeto regex para verificar si la cadena de entrada input coincide 
        }


        //EsValido
        public virtual void EsValido()
        {
          

            if(!(sexo == Enumerado_Genero.macho || sexo == Enumerado_Genero.hembra) || sexo ==null)// Validamos que el sexo sea bien macho o hembra, utilizando los enumerados
            {
                throw new Exception(" Datos invalidos, ganado");

            }

            if( string.IsNullOrEmpty(raza)  )  //Se valida que nada vacio o nulo 
            {
                throw new Exception(" Debe ingresar Un tipo de raza");
            }

            if(costoAdquisicion == null || costoAdquisicion == 0)
            {
                throw new Exception(" Costo de adquisicion vacio");
            }

            if (costoAlimentacion == null || costoAlimentacion == 0)
            {
                throw new Exception(" costo de alimentacion vacio");
            }

            if (pesoActual == null || pesoActual == 0 ) 
            {
                throw new Exception(" peso actual vacio");
            }

            if (fechaNacimiento == null || fechaNacimiento < new DateTime(1980, 2, 2))
            {
                throw new Exception(" Fecha invalida, ganado");
            }

            if (codigoIdentificadorCaravana == null || codigoIdentificadorCaravana.Length != 8 || EsAlfanumerico(codigoIdentificadorCaravana) == false) // el corrobora que el codigo no sea vacio, que su tamaño no supere los 8 digitos y sea alfanumerico
            {
                throw new Exception(" Codigo de identificacion invalido ganado");
            }

        }

        /********Segundo obligatorio*********/

        public virtual double CalcularGanado()
        {
            int CantidadVacunacion = 200 * _vacunacionAnimal.Count;

            return CantidadVacunacion;

        }


        public abstract string TipoGanado();
        


    }
}
