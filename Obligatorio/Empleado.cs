using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    public abstract class Empleado:IValidacion  //Herencia entre Empleado y validacion
    {
        //Atributos
        public int id { get; set; }
        public static int ultimoId { get; set; } = 1;

        public string mail { get; set; }

        public string contraseña { get; set; }

        public string nombre { get; set; }

        public DateTime fechaIngreso { get; set; }

        public string tipo { get; set; }


        //Constructor
        public Empleado()
        {
            id = ultimoId++;
        }

        //Constructor con parametros
        public Empleado(string mail, string contraseña, string nombre, DateTime fechaIngreso, string tipo)
        {
            id = ultimoId++;
            this.mail = mail;
            this.contraseña = contraseña;
            this.nombre = nombre;
            this.fechaIngreso = fechaIngreso;
            this.tipo = tipo;
        }


        //Validacion
        public virtual void EsValido()
        {
            if (string.IsNullOrEmpty(nombre))
            {
                throw new Exception("El nombre no puede estar vacío.");
            }

            if (contraseña == null || contraseña.Length <= 8)
            {
                throw new Exception("La contraseña debe tener más de 8 caracteres.");
            }

            if (string.IsNullOrEmpty(mail))
            {
                throw new Exception("El correo electrónico no puede estar vacío.");
            }
            


        }


        //ToString de la clase
        public override string ToString()
        {
            return $"Nombre {nombre} ";
        }
        //Esto creo que no lo pide la letra





    }
}
