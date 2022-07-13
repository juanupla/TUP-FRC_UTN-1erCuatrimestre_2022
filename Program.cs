using System;

namespace PracticaConLaBoluda2
{
    /* Problema 2.8:
      Capturar los datos de 5 productos comprados en una tienda, incluyendo
      nombre, precio y cantidad en sus 3 listas respectivas, después calcular una cuarta
      lista con el gasto total por cada producto desplegarlo todo en un segundo panel e
      incluir también el gran total. */
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombre = new string[5];
            double[] precio = new double[5];
            int[] cantidad = new int[5];
            double[] gastoTotal = new double[5];
            double granTotal = 0;

            nombre[0] = "Jabon";
            nombre[1] = "Detergente";
            nombre[2] = "Shampoo";
            nombre[3] = "Pañales";
            nombre[4] = "Licuadora";

            precio[0] = 150.75;
            precio[1] = 375.50;
            precio[2] = 585.30;
            precio[3] = 1499.99;
            precio[4] = 10000;

            cantidad[0] = 10;
            cantidad[1] = 5;
            cantidad[2] = 3;
            cantidad[3] = 2;
            cantidad[4] = 1;

            for (int i = 0; i < nombre.Length; i++)
            {
                gastoTotal[i] = cantidad[i] * precio[i];
                granTotal += gastoTotal[i];
                Console.WriteLine("Nombre: " + nombre[i] + " | " + "Precio: $" + precio[i] + " | " + "Cantidad: " + cantidad[i] + " | " + "Gasto Total: $" + gastoTotal[i]);
            }

            Console.WriteLine("Gran Total: $" + granTotal);
            Console.Read();
        }
    }
}