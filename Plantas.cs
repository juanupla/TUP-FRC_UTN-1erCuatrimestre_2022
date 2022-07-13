using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2App2
{
    internal class Plantas
    {
        int codigo;
        string nombre;
        int especie;
        float precio;
        DateTime fecha;

        public Plantas()
        {
            codigo = 0;
            nombre = String.Empty;
            especie = 0;
            precio = 0;
            fecha = DateTime.Now;
        }

        public int pCodigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string pNombre
        {
            get { return nombre; }
            set { nombre = value; }

        }

        public int pEspecie
        {
            get { return especie; }
            set { especie = value; }

        }

        public float pPrecio
        {
            get { return precio; }
            set { precio = value; }
        }

        public DateTime pFecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public override string ToString()
        {
            return "Codigo N°: " + pCodigo + " | Nombre: " + pNombre + " | Especie: " + pEspecie + " | Precio: " + pPrecio + " | Fecha: " + pFecha;
        }
    }
}
