namespace AutomovilApp
{
    //Program es mi archivo ejecutable
    internal class Program
    {
        static void Main(string[] arg) //Mine() es el punto de entrada a mi aplicacion
        {
            //creear nuestros objetos:
            /*
            Automovil auto = new Automovil(); //Puede declarar e inicializar una variable o puede ser Automovil auto; (y abajo) auto = new Automovil. Este metodo permite declarar mas variables de la misma clase
            Automovil auto2 = new Automovil(1000, 20);

            Console.WriteLine("Nivel de combustible actual:" + auto.LtsActuales);
            Console.WriteLine("Auto 2: " + auto2);

            /* Tambien se pueden pedir los datos de kmm y combustible x consola(usuario) */

            //0-Pedir por teclado los datos de combustible y km actuales de un automovil:

            

            int kilometros, litros, litrosCarga, kmRecorrer;

            Automovil oAutomovil; //oAutomovil = null;



            Console.WriteLine("Ingrese cantidad de km del vehículo: ");

            kilometros = int.Parse(Console.ReadLine());



            Console.WriteLine("Ingrese cantidad de litros de combustible del vehículo: ");

            litros = Convert.ToInt32(Console.ReadLine());//Convert permite convertir una cadena a cualquier tipo

            //de datos.



            //1-Crear el automovil

            oAutomovil = new Automovil(kilometros, litros);





            //2-Cargar combustible al automovil:

            Console.WriteLine("Ingrese cantidad litros a cargar: ");

            litrosCarga = Convert.ToInt32(Console.ReadLine());

            int derramados = oAutomovil.CargarCombustible(litrosCarga);



            if (derramados == 0)

                Console.WriteLine("Se cargaron " + litrosCarga + " lts. exitosamente!");

            else

                Console.WriteLine("Se llenó el tanque, se derramaron " + derramados + " lts!");



            //3-Conducir una cierta cantidad de km:



            Console.WriteLine("Ingrese cantidad km a recorrer: ");

            kmRecorrer = Convert.ToInt32(Console.ReadLine());





            if (oAutomovil.Conducir(kmRecorrer) == true)

                Console.WriteLine("Se recorrieron " + kmRecorrer + " kms.");

            else

                Console.WriteLine("No hay combustible suficiente para recorrer " + kmRecorrer + " kms.");
        }
    }
}