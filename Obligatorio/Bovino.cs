using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    public class Bovino:Ganado //Herencia
    {
        //Atributos
        public string TipoAlimentacion { get; set; }
        public double PreciokgBovinoEnPie { get; set; }

        
        //Usando id del padre
        public Bovino():base()
        {

        }

        //Constructor con parametros
        public Bovino(string codigoIdentificadorCaravana, Enumerado_Genero sexo, string raza, DateTime fechaNacimiento, double costoAdquisicion, double costoAlimentacion, double pesoActual, bool hibrido, string tipoAlimentacion, double preciokgBovinoEnPie) : base(codigoIdentificadorCaravana, sexo, raza, fechaNacimiento, costoAdquisicion, costoAlimentacion, pesoActual, hibrido)
        {
            TipoAlimentacion = tipoAlimentacion;
            PreciokgBovinoEnPie = preciokgBovinoEnPie;
        }


        //Validacion 
        public override void EsValido()
        {
            base.EsValido();
            if (string.IsNullOrEmpty(TipoAlimentacion) )
            {
                throw new Exception(" tipo de alimentacion vacio ");
            }

            if ( PreciokgBovinoEnPie == null || PreciokgBovinoEnPie == 0)
            {
                throw new Exception(" PrecioKgBovino Invalido");
            }






        }

        /*Nuevo*/
        public override double CalcularGanado()
        {
            double Peso = pesoActual * PreciokgBovinoEnPie;
            double Crianza = costoAdquisicion + costoAlimentacion;
            double PrecioTotal = Peso - Crianza;

            if (TipoAlimentacion == "Grano")
            {


                if (sexo == Enumerado_Genero.hembra)
                {
                    return base.CalcularGanado() + PrecioTotal * 1.10;
                }
                return base.CalcularGanado() + PrecioTotal * 1.3;

            }
            else
            {
                return base.CalcularGanado() + PrecioTotal;

            }


        }




        public override string TipoGanado()
        {
           if(id == id)
            {
                return "Bovino";
            }
            else
            {
                return "Ovino";
            }
        }





    }
}
