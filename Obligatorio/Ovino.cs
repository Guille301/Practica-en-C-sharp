using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    public class Ovino : Ganado //Herencia
    {
        //Atributos
        public double PesoLana { get; set; }
        private static double PrecioXkgLana { get; set; } = 250;

        public static double PrecioXKgOvino { get; set; } = 500;


        //Constructor de padre
        public Ovino() : base()
        {

        }

        //Constructor con parametros
        public Ovino(string codigoIdentificadorCaravana, Enumerado_Genero sexo, string raza, DateTime fechaNacimiento, double costoAdquisicion, double costoAlimentacion, double pesoActual, bool hibrido, double pesoLana):base( codigoIdentificadorCaravana,  sexo,  raza,  fechaNacimiento,  costoAdquisicion,  costoAlimentacion,  pesoActual,  hibrido)
        {
            PesoLana = pesoLana;
           
        }

        

        //*****METODOS****




        //Cambiar Precio de lana
        public static bool CambiarPrecioLana(double monto)
        {

            if (monto > 0)
            {
                PrecioXkgLana = monto;
                return true;
            }
            return false;

        }


        //Obtener el precio de lana
        public static double ObtenerPrecioLana()
        {
            return PrecioXkgLana;
        }


        //Validacion
        public override void EsValido()
        {
            base.EsValido();
            if(PesoLana == null || PrecioXkgLana==null || PrecioXKgOvino == null)
            {
                throw new Exception("Error de datos ovino");
            }
        }




        public override double CalcularGanado()
        {

            double Lana = PesoLana * PrecioXkgLana;
            double Crianza = costoAdquisicion + costoAlimentacion;
            double EnPie = PrecioXKgOvino * pesoActual;

            if (hibrido)
            {
                return  Crianza + Lana + EnPie * 0.5 - base.CalcularGanado() ;

            }
            else
            {
                return   Crianza + Lana + EnPie  - base.CalcularGanado();

            }


        }

        public override string TipoGanado()
        {
            if (id == id)
            {
                return "Ovino";
            }
            else
            {
                return "Bovino";
            }
        }








    }

}
