using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formsTelefoicaApp
{
    internal class Telefono
    {
        private int codigo;
        private string nombre;
        private int marca;
        private float precio;

        public Telefono()
        {
            codigo = 0;
            nombre = "";
            marca = 0;
            precio = 0;
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
        public int pMarca
        {
            get { return marca; }
            set { marca = value; }
        }
        public float pPrecio
        {
            get { return precio; }
            set { precio = value; }
        }

        public override string ToString()
        {
            return pCodigo + ", " + pNombre;
        }
    }
}
