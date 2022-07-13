using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2punto8App1
{
    internal class Tienda
    {
        private Producto[] nombre;
        private Producto[] precio;
        private Producto[] cantidad;
        private int posicion;


        public Tienda()
        {
            this.nombre = new Producto[5];
            this.precio = new Producto[5];
            this.cantidad = new Producto[5];
            this.posicion = 0;
        }

        public Tienda(int cantidadNombre,int cantidadPrecio, int cantidadCantidad)
        {
            this.nombre = new Producto[cantidadNombre];
            this.precio = new Producto[cantidadPrecio];
            this.cantidad = new Producto[cantidadCantidad];
            this.posicion = 0;    
        }


        public bool agregarNombre(Producto oProducto)
        {
            if (posicion < nombre.Length)
            {
                    nombre[posicion] = oProducto;
                    posicion++;
                    return true;
            }
            else
                return false;
        }

        public bool agregarCantidad(Producto oProducto)
        {
            if (posicion < cantidad.Length)
            {
                cantidad[posicion] = oProducto;
                posicion++;
                return true;
            }
            else
                return false;
        }

        public bool agregarPrecio(Producto oProducto)
        {
            if (posicion < precio.Length)
            {
                precio[posicion] = oProducto;
                posicion++;
                return true;
            }
            else
                return false;
        }

        public string mostrarNombre()
        {
            string lista = "";
            for (int i = 0; i < nombre.Length; i++)
            {
                if (nombre[i] != null)
                {
                    lista += nombre[i];
                }
            }
            return lista.ToString();
        }
    }
}
