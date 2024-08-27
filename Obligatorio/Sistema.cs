using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    public class Sistema
    {
        //Listas
        private List<Empleado> _empleados = new List<Empleado>();
        private List<Ganado> _ganados = new List<Ganado>();
        private List<Vacuna> _vacunas = new List<Vacuna>();
        private List<Potrero> _potreros = new List<Potrero>();


        public Sistema()
        {
            //Invocamos Metodo de Precarga
            Precarga();
        }

        //Metodo de Precarga
        private void Precarga()
        {
            //Precarga de Peones


            Peon emp1 = new Peon("correo2@example.com", "pass51234", "Pedro Espinoza", new DateTime(2021, 5, 10), "peon", false);
            Peon emp2 = new Peon("correo1@example.com", "pass51234", "Maria Garcia", new DateTime(2021,5,10), "peon", false);
            Peon emp3 = new Peon("usuario2@mail.com", "pass12534", "Pedro Lopez", new DateTime(2023,12,01), "peon", true);
            Peon emp4 = new Peon("email3@example.org", "pass15234", "Ana Martinez", new DateTime(2020, 11, 30), "peon", false);
            Peon emp5 = new Peon("correo4@gmail.com", "pass12534", "Carlos Sanchez", new DateTime(2022, 7, 20), "peon", true);
            Peon emp6 = new Peon("usuario5@yahoo.com", "pass12534", "Laura Rodriguez", new DateTime(2021, 12, 5), "peon", false);
            Peon emp7 = new Peon("email6@hotmail.com", "pass15234", "Miguel Gonzalez", new DateTime(2023, 3, 8), "peon", true);
            Peon emp8 = new Peon("usuario7@live.com", "pass12354", "Sofía Hernández", new DateTime(2022, 6, 12), "peon", false);
            Peon emp9 = new Peon("correo8@example.com", "pass12354", "Javier Ramirez", new DateTime(2024, 4, 25), "peon", true);
            Peon emp10 = new Peon("usuario9@mail.com", "pass12345", "Marina Lopez", new DateTime(2023, 10, 17), "peon", false);




            //Alta de Empeado (Peon)

            AltaEmpleado(emp1);
            AltaEmpleado(emp2);
            AltaEmpleado(emp3);
            AltaEmpleado(emp4);
            AltaEmpleado(emp5);
            AltaEmpleado(emp6);
            AltaEmpleado(emp7);
            AltaEmpleado(emp8);
            AltaEmpleado(emp9);
            AltaEmpleado(emp10);

            //Precarga de Capataz
            Capataz cap1 = new Capataz("juna@gmail.com","12345abcd","JUAN pablo",new DateTime (2024,05,05),"Capataz",6);
            Capataz cap2 = new Capataz("Miguel@gmail.com", "12345efgh", "Miguel Ohara", new DateTime(2024, 08 ,09), "Capataz", 3);
            Capataz cap3 = new Capataz("sebas@gmail.com", "12345ssss", "Sebastian Montano", new DateTime(2024, 08, 09), "capataz", 2);
            Capataz cap4 = new Capataz("asdi@jha", "pass15234", "Juan Perez", new DateTime(2 / 2 / 2022), "capataz", 5);

            //Alta de Empleado (Capataz)
            AltaEmpleado(cap1);
            AltaEmpleado(cap2);
            AltaEmpleado(cap3);
            AltaEmpleado(cap4);



            //Precarga de Ganados(Ovinos)

            Ovino ov1 = new Ovino("ABC43duA",Enumerado_Genero.hembra , "Merino Australiano", new DateTime(2024, 6, 17), 65, 30, 120, false, 40);
            Ovino ov2 = new Ovino("ABC43duB", Enumerado_Genero.hembra, "Suffolk", new DateTime(2020, 8, 10), 80, 35, 150, true, 50);
            Ovino ov3 = new Ovino("ABC43duC", Enumerado_Genero.hembra, "Romney", new DateTime(2018, 4, 25), 70, 32, 135, false, 45);
            Ovino ov4 = new Ovino("ABC43duD", Enumerado_Genero.macho, "Corriedale", new DateTime(2021, 2, 12), 75, 34, 140, true, 48);
            Ovino ov5 = new Ovino("ABC43duE", Enumerado_Genero.macho, "Cheviot", new DateTime(2020, 10, 5), 68, 31, 125, false, 42);
            Ovino ov6 = new Ovino("ABC56hdF", Enumerado_Genero.macho, "Dorset Horn", new DateTime(2019, 7, 15), 85, 37, 155, true, 55);
            Ovino ov7 = new Ovino("ABC43duG", Enumerado_Genero.macho, "Lincoln", new DateTime(2021, 1, 30), 72, 33, 130, false, 44);
            Ovino ov8 = new Ovino("ABC43duH", Enumerado_Genero.macho, "Cotswold", new DateTime(2020, 9, 18), 78, 36, 145, true, 52);
            Ovino ov9 = new Ovino("ABC43duI", Enumerado_Genero.macho, "Polwarth", new DateTime(2019, 5, 12), 66, 30, 122, false, 41);
            Ovino ov10 = new Ovino("ABC43duJ", Enumerado_Genero.macho, "Hampshire", new DateTime(2021, 3, 8), 82, 38, 160, true, 58);
            Ovino ov11 = new Ovino("ABC43duK", Enumerado_Genero.macho, "Rambouillet", new DateTime(2020, 11, 20), 70, 32, 128, false, 43);
            Ovino ov12 = new Ovino("ABC43duL", Enumerado_Genero.macho, "Targhee", new DateTime(2019, 8, 25), 76, 35, 148, true, 50);
            Ovino ov13 = new Ovino("ABC12312", Enumerado_Genero.macho, "Navajo-Churro", new DateTime(2018, 6, 10), 68, 31, 126, false, 40);
            Ovino ov14 = new Ovino("ABC1b231", Enumerado_Genero.hembra, "Jacob", new DateTime(2020, 4, 15), 83, 39, 162, true, 56);
            Ovino ov15 = new Ovino("ABC1b277", Enumerado_Genero.hembra, "Polypay", new DateTime(2019, 10, 30), 71, 33, 132, false, 45);

            //Alta de Gandado (Ovinos)

            AltaGanado(ov1);
            AltaGanado(ov2);
            AltaGanado(ov3);
            AltaGanado(ov4);
            AltaGanado(ov5);
            AltaGanado(ov6);
            AltaGanado(ov7);
            AltaGanado(ov8);
            AltaGanado(ov9);
            AltaGanado(ov10);
            AltaGanado(ov11);
            AltaGanado(ov12);
            AltaGanado(ov13);
            AltaGanado(ov14);
            AltaGanado(ov15);



            //Precarga de Ganados(Bovinos)
            Bovino bov1 = new Bovino("ABC12341", Enumerado_Genero.hembra, "Angus", new DateTime(2020, 10, 10), 78, 35, 145, false, "pasto", 25);
            Bovino bov2 = new Bovino("ABC12351", Enumerado_Genero.hembra, "Holstein", new DateTime(2021, 3, 5), 82, 37, 152, true, "pasto", 28);
            Bovino bov3 = new Bovino("ABC12361", Enumerado_Genero.hembra, "Charolais", new DateTime(2020, 7, 20), 75, 33, 140, false, "pasto", 22);
            Bovino bov4 = new Bovino("ABC12371", Enumerado_Genero.hembra, "Limousin", new DateTime(2019, 8, 25), 80, 36, 148, true, "pasto", 27);
            Bovino bov5 = new Bovino("ABC12381", Enumerado_Genero.hembra, "Simmental", new DateTime(2018, 6, 10), 73, 31, 132, false, "pasto", 20);
            Bovino bov6 = new Bovino("ABC12391", Enumerado_Genero.macho, "Gyr", new DateTime(2021, 4, 10), 85, 38, 155, true, "pasto", 30);
            Bovino bov7 = new Bovino("ABC12310", Enumerado_Genero.macho, "Brahman", new DateTime(2020, 12, 25), 70, 30, 125, false, "pasto", 18);
            Bovino bov8 = new Bovino("ABC71231", Enumerado_Genero.macho, "Jersey", new DateTime(2019, 9, 10), 75, 34, 140, true, "pasto", 23);
            Bovino bov9 = new Bovino("ABC12fg3", Enumerado_Genero.macho, "Brangus", new DateTime(2018, 7, 20), 72, 32, 135, false, "pasto", 21);
            Bovino bov10 = new Bovino("ABCrgrg1", Enumerado_Genero.macho, "Santa Gertrudis", new DateTime(2021, 2, 28), 80, 36, 150, true, "pasto", 28);
            Bovino bov11 = new Bovino("ABC1dgr2", Enumerado_Genero.macho, "Murray Grey", new DateTime(2020, 11, 10), 68, 29, 120, false, "pasto", 16);
            Bovino bov12 = new Bovino("ABC12dfg", Enumerado_Genero.macho, "Red Angus", new DateTime(2019, 10, 5), 77, 35, 145, true, "pasto", 25);
            Bovino bov13 = new Bovino("ABC1dfgh", Enumerado_Genero.macho, "Hereford", new DateTime(2018, 8, 10), 70, 31, 130, false, "pasto", 19);
            Bovino bov14 = new Bovino("ABsdvC11", Enumerado_Genero.macho, "Aberdeen Angus", new DateTime(2021, 5, 18), 83, 38, 155, true, "pasto", 30);
            Bovino bov15 = new Bovino("ABsdvC12", Enumerado_Genero.macho, "Chianina", new DateTime(2020, 12, 5), 65, 28, 115, false, "pasto", 15);

            //Alta de Gandado (Bovinos)
            AltaGanado(bov1);
            AltaGanado(bov2);
            AltaGanado(bov3);
            AltaGanado(bov4);
            AltaGanado(bov5);
            AltaGanado(bov6);
            AltaGanado(bov7);
            AltaGanado(bov8);
            AltaGanado(bov9);
            AltaGanado(bov10);
            AltaGanado(bov11);
            AltaGanado(bov12);
            AltaGanado(bov13);
            AltaGanado(bov14);
            AltaGanado(bov15);
   








            //Precarga de vacunas
            Vacuna v2 = new Vacuna("Covexin 8", "preventiva", "Clostridium chauvoei, septicum, novyi, sordellii, perfringens Type C&D");
            Vacuna v3 = new Vacuna("Multivax-P Plus", "preventiva", "Clostridium perfringens Types A, B, C and D");
            Vacuna v4 = new Vacuna("Bovilis Bovipast RSP", "preventiva", "Mannheimia haemolytica and Pasteurella multocida");
            Vacuna v5 = new Vacuna("Ovipast Plus", "preventiva", "Clostridium perfringens Types C and D");
            Vacuna v6 = new Vacuna("Spirovac", "preventiva", "Leptospira hardjo, Leptospira pomona and Leptospira borgpetersenii serovar hardjo-bovis");
            Vacuna v7 = new Vacuna("Ultravac 7in1", "preventiva", "Leptospira Hardjo, L. Pomona, L. Canicola, L. Icterohaemorrhagiae");
            Vacuna v8 = new Vacuna("Bovivac S", "preventiva", "Mannheimia haemolytica, Pasteurella multocida");
            Vacuna v9 = new Vacuna("Covexin 10", "preventiva", "Clostridium chauvoei, septicum");
            Vacuna v10 = new Vacuna("Gudair", "preventiva", "Mycobacterium avium subsp. Paratuberculosis");
            Vacuna v11 = new Vacuna("Heptavac-P Plus", "preventiva", "Clostridium perfringens Type A, C. ");

            //Alta de Vacunas
            AltaVacuna(v2);
            AltaVacuna(v3);
            AltaVacuna(v4);
            AltaVacuna(v5);
            AltaVacuna(v6);
            AltaVacuna(v7);
            AltaVacuna(v8);
            AltaVacuna(v9);
            AltaVacuna(v10);
            AltaVacuna(v11);

           
             


            //Precarga de Potrero
            Potrero p1 = new Potrero("Cerrado", 23, 3);
            Potrero p2 = new Potrero("Colina", 12, 23);
            Potrero p3 = new Potrero("Montaña", 15, 70);
            Potrero p4 = new Potrero("Valle", 20, 50);
            Potrero p5 = new Potrero("Pradera", 25, 45);
            Potrero p6 = new Potrero("Bosque", 10, 3);
            Potrero p7 = new Potrero("Colina", 18, 63);
            Potrero p8 = new Potrero("Llanura", 22, 58);
            Potrero p9 = new Potrero("Abierto", 28, 42);
            Potrero p10 = new Potrero("Penillanura", 12, 3);

            //Alta de Potrero
            AltaPotrero(p1);
            AltaPotrero(p2);
            AltaPotrero(p3);
            AltaPotrero(p4);
            AltaPotrero(p5);
            AltaPotrero(p6);
            AltaPotrero(p7);
            AltaPotrero(p8);
            AltaPotrero(p9);
            AltaPotrero(p10);

            //Precarga de Tareas
            Tarea t1 = new Tarea("Alimentar", new DateTime(2000, 2, 2), false, new DateTime(2001, 5, 5), "Tarea en espera");
            Tarea t2 = new Tarea("Curar", new DateTime(2020, 4, 5), true, new DateTime(2022, 11, 9), "Tarea realizada");
            Tarea t3 = new Tarea("Alimentar", new DateTime(2000, 6, 2), false, new DateTime(2002, 5, 2), "Tarea en espera");
            Tarea t4 = new Tarea("Curar", new DateTime(2000, 7, 8), true, new DateTime(2002, 2, 2), "Tarea realizada");
            Tarea t5 = new Tarea("Organizar", new DateTime(2000, 12, 10), false, new DateTime(2002, 2, 2), "En proceso");
            Tarea t6 = new Tarea("Alimentar", new DateTime(2000, 12, 2), true, new DateTime(2002, 2, 2), "Tarea realizada");
            Tarea t8 = new Tarea("Alimentar", new DateTime(2000, 2, 16), false, new DateTime(2002, 2, 2), "En progreso");
            Tarea t9 = new Tarea("Curar", new DateTime(2002, 2, 18), true, new DateTime(2002, 2, 2), "Tarea realizada");
            Tarea t10 = new Tarea("Alimentar", new DateTime(2000, 2, 12), false, new DateTime(2012, 3, 7), "En espera");
            Tarea t11 = new Tarea("Curar", new DateTime(2002, 10, 2), true, new DateTime(2002, 2, 2), "Tarea realizada");
            Tarea t12 = new Tarea("Organizar", new DateTime(2000, 4, 2), false, new DateTime(2005, 5, 10), "Tarea en progreso");
            Tarea t13 = new Tarea("Alimentar", new DateTime(2000, 2, 26), true, new DateTime(2002, 2, 2), "Tarea realizada");
            Tarea t14 = new Tarea("Curar", new DateTime(2000, 11, 7), true, new DateTime(2002, 2, 2), "Tarea realizada");
            Tarea t15 = new Tarea("Limpiar", new DateTime(2000, 9, 7), false, new DateTime(2002, 2, 2), "En proceso");


            //Asignacion de Tarea Peon

            AsignarTareaAlPeon(emp2, t1);
            AsignarTareaAlPeon(emp3, t3);
            AsignarTareaAlPeon(emp4, t4);
            AsignarTareaAlPeon(emp5, t5);
            AsignarTareaAlPeon(emp6, t6);
            AsignarTareaAlPeon(emp8, t8);
            AsignarTareaAlPeon(emp9, t9);
            AsignarTareaAlPeon(emp10, t10);
            AsignarTareaAlPeon(emp6, t11);
            AsignarTareaAlPeon(emp7, t12);
            AsignarTareaAlPeon(emp8, t13);
            AsignarTareaAlPeon(emp9, t14);
            AsignarTareaAlPeon(emp7, t1);
            AsignarTareaAlPeon(emp7, t2);
            AsignarTareaAlPeon(emp7, t10);
            AsignarTareaAlPeon(emp1, t15);





            //Asignacion de Ganado Potrero
            AsignarGanadoAPotrero(bov11,p1);
            AsignarGanadoAPotrero(bov12,p2);
            AsignarGanadoAPotrero(bov13,p3);
            AsignarGanadoAPotrero(bov14,p1);
            AsignarGanadoAPotrero(bov15, p1);
            AsignarGanadoAPotrero(ov1 ,p2);
            AsignarGanadoAPotrero(ov2 ,p4);
            AsignarGanadoAPotrero(ov3 ,p6);
            AsignarGanadoAPotrero(ov4,p7);
            AsignarGanadoAPotrero(ov5,p8);
            AsignarGanadoAPotrero(ov8,p10);
            AsignarGanadoAPotrero(ov1,p1);
            AsignarGanadoAPotrero(bov1, p5);
            AsignarGanadoAPotrero(bov2, p2);
            AsignarGanadoAPotrero(bov3, p3);
            AsignarGanadoAPotrero(bov4, p1);
            AsignarGanadoAPotrero(bov5, p4);
            AsignarGanadoAPotrero(ov11, p2);
            AsignarGanadoAPotrero(ov13, p6);
            AsignarGanadoAPotrero(ov14, p7);
            AsignarGanadoAPotrero(ov15, p8);



            
            //Asignacion de Vacunas (Bovinos)
            bov1.AsignarVacunacionAnimal( new DateTime(2 / 2 / 2023), v3);
            bov2.AsignarVacunacionAnimal( new DateTime(2 / 3 / 2022), v4);
            bov3.AsignarVacunacionAnimal( new DateTime(9 / 5 / 2023), v11);
            bov4.AsignarVacunacionAnimal( new DateTime(3 / 3 / 2024), v5);
            bov5.AsignarVacunacionAnimal( new DateTime(7 / 7 / 2022), v8);
            bov6.AsignarVacunacionAnimal( new DateTime(2 / 2 / 2023), v4);
            bov7.AsignarVacunacionAnimal( new DateTime(2 / 5 / 2023), v10);
            bov8.AsignarVacunacionAnimal( new DateTime(2 / 2 / 2022), v3);
            bov9.AsignarVacunacionAnimal( new DateTime(2 / 2 / 2022), v3);
            bov10.AsignarVacunacionAnimal( new DateTime(2 / 2 / 2022), v3);
            bov11.AsignarVacunacionAnimal( new DateTime(2 / 2 / 2023), v3);
            bov12.AsignarVacunacionAnimal( new DateTime(6 / 6 / 2022), v3);


            //Asignacion de Vacunas (Ovinos)
            ov1.AsignarVacunacionAnimal( new DateTime(9 / 5 / 2023), v11);
            ov2.AsignarVacunacionAnimal( new DateTime(9 / 1 / 2022), v2);
            ov3.AsignarVacunacionAnimal( new DateTime(9 / 2 / 2023), v2);
            ov4.AsignarVacunacionAnimal( new DateTime(9 / 3 / 2023), v3);
            ov5.AsignarVacunacionAnimal( new DateTime(9 / 4 / 2023), v4);
            ov6.AsignarVacunacionAnimal( new DateTime(9 / 5 / 2023), v5);
            ov7.AsignarVacunacionAnimal( new DateTime(9 / 6 / 2023), v6);
            ov8.AsignarVacunacionAnimal( new DateTime(9 / 7 / 2023), v7);
            ov9.AsignarVacunacionAnimal( new DateTime(9 / 8 / 2023), v8);
            ov10.AsignarVacunacionAnimal( new DateTime(9 / 10 / 2003), v10);







        }

        /*OBTENER lISTAS*/
        public List<Empleado> GetEmpleados()
        {
            return _empleados;
        }

        public List<Ganado> GetGanados()
        {
            return _ganados;
        }

        public List<Vacuna> GetVacunas()
        {
            return _vacunas;
        }

        public List<Potrero> GetPotreros()
        {
            return _potreros;
        }

        /*ALTAS */


        /*
           public void AltaEmpleado(Empleado e)
        {
          
                e.EsValido();
                _empleados.Add(e);
        
           
            
        }
         */


        //Modificacion de Hoy
        public void DatosUnicosPeon(string mail, string nombre)
        {
            foreach (Empleado e in _empleados)
            {
                if (e.mail == mail || e.nombre == nombre)
                {
                    throw new Exception("Los datos estan repetidos");

                }
            }
        }




        public void AltaEmpleado(Empleado e)
        {

            DatosUnicosPeon(e.mail, e.nombre);
            e.EsValido();
            _empleados.Add(e);



        }



        public void AltaGanado(Ganado g)
        {
            


                identificadorAlfaNumerico8DigitosUnico(g.codigoIdentificadorCaravana);
                    g.EsValido();
                    _ganados.Add(g);



            
            
        }

        public void AltaVacuna(Vacuna v)
        {

            try
            {
                
                v.EsValido();
                _vacunas.Add(v); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ingresar datos");
                Console.WriteLine(ex.Message);

            }

        }

        public void AltaPotrero(Potrero p)
        {
            try
            {
                p.EsValido();
                _potreros.Add(p);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error al ingresar los datos");
                Console.WriteLine(ex.Message);
            }
            

            



        }




        //*****METODOS*****



        // Asignar Tarea al Peon
        public bool AsignarTareaAlPeon(Peon p , Tarea t)
        {
            p.ValidarTarea(t);
            p.AgregarTarea(t);
            return true;

        }


        // Asignar Ganado a Potrero
        public bool AsignarGanadoAPotrero(Ganado g , Potrero p){

            
            p.AgregarAnimalAlPotrero(g);
            return true;
           

          

        }










         // Identificador Alfanumerico de 8 digitos 
        public void identificadorAlfaNumerico8DigitosUnico(string codigo )
        {
            foreach(Ganado g in _ganados) 
            {
                if (g.codigoIdentificadorCaravana == codigo)
                {
                    throw new Exception ("Codigo ya existe");
                }
            }

           
        }

   



        /*Precio kg Lana*/

        public bool CambiarPrecioLana(double monto)
        {

            return Ovino.CambiarPrecioLana(monto);




        }
       
        // Obtener Precio kg Lana (Ovino)
        public double ObtenerPrecioKgLana()
        {
            return Ovino.ObtenerPrecioLana();
        }


        // Enumerado ver Genero Animal
        public Enumerado_Genero verGeneroAnimal(string s)
        {
            Enumerado_Genero genero; 

            if (s.ToLower() == "macho") // Convertimos en input en caso de serlo a minuscula y los comparamos con el valor del enumerado
            {

                return genero = Enumerado_Genero.macho;
               

            }
            else if (s.ToLower() == "hembra")
            {
                return genero = Enumerado_Genero.hembra;


            }
            else
            {
                throw new ArgumentException("El valor de 'sexo' debe ser 'macho' o 'hembra'.");
            }
            
        }



        // Obtener Potreros Mayores 
        public List<Potrero> GetPotrerosMayores(int hectareas, int num)
        {
            List<Potrero> _retornoPotrero = new List<Potrero>();

            foreach (Potrero p in _potreros)
            {
                if (p.cantidadHectareas > hectareas && p.capacidadMaximaAnimales > num)
                {
                    _retornoPotrero.Add(p);
                }
            }
            return _retornoPotrero;
        }



        /***********************Obligatorio segunda parte********************************/
        private static Sistema instancia = null;

        public static Sistema GetInstancia()
        {
            if(instancia == null)
            {
                instancia = new Sistema();
            }
            return instancia;
        }





        public Empleado Login(string email, string password)
        {
            foreach(Empleado e in _empleados)
            {
                if(e.mail.Equals(email) && e.contraseña.Equals(password))
                {
                    return e;
                }
            }
            return null;
        }



        /*Asignar vacuna*/

        
        public Vacuna BuscarVacunaXId(int id)
        {
            foreach (Vacuna v in _vacunas)
            {
                if (v.Id.Equals(id))
                {
                    return v;
                }
            }
            return null;
        }

      

        public bool AsignarVacunaAnimal(Ganado g ,DateTime fecha ,Vacuna v)
        {


            g.ValidacionVacuna(fecha);
      g.AsignarVacunacionAnimal( fecha, v);
      return true;

        }

       


        public Ganado BuscarGanadoXId(int id)
        {
            foreach(Ganado g in _ganados)
            {
                if (g.id.Equals(id))
                {
                    return g;
                }
            }
            return null;
        }

       
       







        /*Buscar empleado por id*/

        public Empleado BuscarEmpleadoPorId(int? id)
        {
            foreach (Empleado e in _empleados)
            {
                if (e.id.Equals(id))
                {
                    return e;
                }
            }
            return null;
        }


        /*Buscar Peon Por ID*/
        public Peon BuscarPeonPorId(int? idPeon)
        {
            foreach (Empleado e in _empleados)
            {
                if (e.id.Equals(idPeon) && e is Peon )
                {
                    return (Peon)e;
                }
            }
            return null;
        }

        /*Tareas del peon*/





        /*Completar tareas pendientes*/










        public void TareaRealizada(Tarea t)
        {
            // Busca la persona existente por ID

            Tarea TareaExistente = null; 

            foreach (var empleado in _empleados)
            {
                if(empleado is Peon p)
                {
                    TareaExistente = p.GetTareas().FirstOrDefault(Tarea => Tarea.Id == t.Id);

                    if (TareaExistente != null)
                    {
                        break;
                    }
                }
               

            }

            if (t.ComentarioPeon != "" && t.ComentarioPeon !=null)
            {
                if (TareaExistente != null)
                {
                    TareaExistente.ComentarioPeon = t.ComentarioPeon;
                    TareaExistente.SiSeCompleto = true;

                }
                else
                {
                    throw new Exception("Tarea no encontrada");
                }
            }
            else
            {
                throw new Exception("Comentario Vacio");
            }

           

            

          





        }
        

        public int GetIdTarea(int id)
        {
            Peon p = new Peon();
            int ret = 0;
            List<Tarea> _tareas = p.GetTareas();
            foreach(Tarea t in _tareas)
            {
                if (t.Id.Equals(id))
                {
                    ret = t.Id;
                    
                }
            }
            return ret;
        }


        /*Ordenar tarea*/




        public List<Tarea> BuscarTarea(int? id)
        {
            List<Tarea> tareasEncontradas = new List<Tarea>();


                 foreach (Empleado empleado in _empleados)
                  {

                    if (empleado.id == id && empleado is Peon p)
                    {
                        tareasEncontradas = p.GetTareas();
                        tareasEncontradas = tareasEncontradas.OrderBy(t => t.FechaDeRealizacion).ToList();

          
                        return tareasEncontradas; 
                    }
                }
            
            return null; 
        }













        /*************Asignar ganado al potrero***********/

        public Potrero BuscarPotreroXId(int id)
        {
            foreach (Potrero p in _potreros)
            {
                if (p.id.Equals(id))
                {
                    return p;
                }
            }
            return null;
        }

        public bool AsignarGanadoLibre(Ganado g, Potrero p)
        {

            

            if (GanadoLibre(g) == true  && p.AgregarAnimalAlPotrero(g)==true)
            {
                p.AgregarAnimalAlPotrero(g);
                return true;
            }
            else
            {

                throw new Exception("Capacidad Alcancazada");

            }
        }



        public bool GanadoLibre(Ganado g)
        {
            foreach (Potrero p in _potreros)
            {
                foreach (Ganado i in p.GetGanado())
                {
                    if (i.id == g.id)
                    {
                        return false;
                    }
                }
            }
            return true;
        }



        /************Mostrar solo peones**********/


        public List<Empleado> SoloPeones()
        {

            List<Empleado> peones = new List<Empleado>();


            foreach(Empleado e in _empleados)
            {
                if(e.tipo == "peon")
                {
                    peones.Add(e);
                }
            }
            return peones;

        }


        /************** Buscador  *******************/

        public List<Ganado> BuscarXPesoYTipo(int peso, string tipo)
        {
            List<Ganado> ret = new List<Ganado>();
            foreach (Ganado p in _ganados)
            {
                if (p is Bovino)
                {
                    Bovino b = p as Bovino;
                    if (p.pesoActual > peso && p.TipoGanado() == tipo)
                    {



                        ret.Add(b);


                    }
                } else if (p is Ovino)
                {

                    Ovino o = p as Ovino;

                    if (p.pesoActual > peso && p.TipoGanado() == tipo)
                    {



                        ret.Add(o);


                    }




                }







            }

            if (ret.Count == 0 || peso ==0)
            {
                throw new Exception("No existen animales que coincidan con los criterios especificados.");
            }
            
            return ret;
        }


       


 






    }
}
