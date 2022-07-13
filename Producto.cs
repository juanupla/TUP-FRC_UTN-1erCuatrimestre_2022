using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2punto8App1
{
    internal class Producto
    {
        private string nombre;
        private double precio;
        private int cantidad;
        private int posicion;

        public Producto()
        {
            this.precio = 0;
            this.cantidad = 0;
            this.nombre = "";
            this.posicion = 0;

        }

        public Producto(string nombre, double precio, int cantidad)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
            this.posicion = 0;

        }

        public string pNombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public double pPrecio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        public int pCantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }
        public override string ToString()
        {
            return "Nombre: " + nombre + "| Precio: " + precio + "| Cantidad: " + cantidad;
        }
      
       
    }
}