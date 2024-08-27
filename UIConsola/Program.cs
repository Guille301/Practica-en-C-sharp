using Obligatorio;

namespace UIConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Invocamos a la clase Sistema
            Sistema s = new Sistema();


            //Inicializamos la op en -1
            int op = -1;

            
            //Minetras op sea distinto de 0, se ejecutara todo dentro del while
            while (op != 0)
            {


               //Invocamos al menu
                ArmarMenu();
                op = int.Parse(Console.ReadLine());
              
                if (op == 1)
                {

                    
                    //Obtenemos la lista de ganados
                    List<Ganado> lg = s.GetGanados();
                    if (lg.Count > 0)
                    {
                        //Recorremos y mostramos la lista de ganados
                        foreach (Ganado g in lg)
                        {
                            Console.WriteLine(g.codigoIdentificadorCaravana + " " + g.raza + " " + g.pesoActual + " " + g.sexo);
                        }
                    }
                    else
                    {
                        Console.WriteLine("NO se encontraron animales");
                    }
                   


                }
                else if (op == 2)
                {
                    //Pedimos los datos necesarios al usuario
                    Console.WriteLine("ingrese cantidad de Hectareas");
                    int cantH= int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese cantidad de Animales");
                    int num = int.Parse(Console.ReadLine());

                    //invocamos el metodo GetPotrerosMayores
                    List<Potrero> po = s.GetPotrerosMayores(cantH, num);
                    
                    if (po.Count > 0)
                        //Este count lo usamos para comprobar si la lista esta vacia o no.
                    {
                        //Recorremos la lista de potreros y mostramos los que cumple con los parametros 
                        foreach (Potrero p in po)
                        {


                            Console.WriteLine(p.descripcion + " " + p.cantidadHectareas + " " + p.capacidadMaximaAnimales + " " + p.id);





                        }

                    }
                    else 
                    {
                        Console.WriteLine("No hay Potrero");
                    }
                 







                }
                else if (op == 3)
                {
                    Console.WriteLine("Precio Actual:" + s.ObtenerPrecioKgLana());
                    Console.WriteLine("Ingrese el nuevo precio");
                    double nuevoValor = double.Parse(Console.ReadLine());

                    bool cambio = s.CambiarPrecioLana(nuevoValor);

                    if (cambio)
                    {
                        Console.WriteLine("El precio cambio correctamente");
                        Console.WriteLine("Ahora es:"+ s.ObtenerPrecioKgLana());
                    }


                }
                else if (op == 4)
                {

                    // try y catch  para capturar las excepciones 
                    try
                    {

                        Console.WriteLine("Ingrese Numero de Caravana");
                        string numCaravana = Console.ReadLine();

                        Console.WriteLine("Ingrese Sexo del Animal:");
                        string sexo = Console.ReadLine();

                        Console.WriteLine("Ingrese la Fecha De Nacimiento:");
                        DateTime fn = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese Costo De  Adquisicion:");
                        double ca = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese Costo De Alimentacion:");
                        double cal = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese Peso Actual:");
                        double peso = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Hibrido?:");
                        bool hi = bool.Parse(Console.ReadLine());


                        Console.WriteLine("Tipo de Alimentacion");
                        string tipoAl = Console.ReadLine();


                        Console.WriteLine("KG Bovino en Pie:");
                        double Bkg = Double.Parse(Console.ReadLine());


                        Console.WriteLine("Ingrese la raza:");
                        string raza = Console.ReadLine();





                        Ganado nuevo = new Bovino(numCaravana, s.verGeneroAnimal(sexo), raza, fn, ca, cal, peso, hi, tipoAl, Bkg);


                        s.AltaGanado(nuevo);
                        
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error");
                     
                        
                    }


                } 
              
               

                Console.ReadKey();

               

            }


        }

        private static void ArmarMenu()
            {
                Console.Clear();
                Console.WriteLine("1 - Listar Animales");
                Console.WriteLine("2 - Listar Potreros con Area Mayor");
                Console.WriteLine("3 - Establecer Precio de Lana Ovinos x Kilogramos");
                Console.WriteLine("4 - Alta Ganado bovino");
                

                

            }










        }
    }

