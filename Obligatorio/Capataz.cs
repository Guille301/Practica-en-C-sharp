using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    public class Capataz:Empleado //Herencia
    {

        public int personaACargo { get; set; }



        //Constructor de padre
        public Capataz():base()
        {
            
        }

        //Constructor con parametros 
        public Capataz(string mail, string contraseña, string nombre, DateTime fechaIngreso, string tipo, int personaACargo): base (mail,  contraseña,  nombre,  fechaIngreso, tipo)
        {
            this.personaACargo = personaACargo;
        }

        //Validacion
        public override void EsValido()
        {
            base.EsValido();
            //Esto sirve para implementar tambien las exception del padre
            if (personaACargo == null)
            {
                throw new Exception("invalido Capataz");
            }
            //pongo los datos de validacion de capataz
        }


        //Metodo TO string de la clase
        public override string ToString()
        {
            return base.ToString() + $"Personas a cargo {personaACargo} ";
        }

    }
}
