using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLiga
{
    class Jugador : Persona
    {
        private string posicion;
        private bool lesionado;
        private int faltasAcumuladas;

        public Jugador(string nombre, string apellido, string grupoSangineo, DateTime fecha_nacimiento, string posicion, bool lesionado, int faltasAcumuladas)
        : base(nombre, apellido, grupoSangineo, fecha_nacimiento)
        {
            this.posicion = posicion;
            this.lesionado = lesionado;
            this.faltasAcumuladas = faltasAcumuladas;
        }

        public Jugador() : base()
        {
            this.posicion = string.Empty;
            this.lesionado = false;
            this.faltasAcumuladas = 0;
        }

        public string pPosicion
        {
            get { return this.posicion; }
            set { this.posicion = value; }
        }
        public bool Plesionado
        {
            get { return this.lesionado; }
            set { this.lesionado = value; }
        }

        public bool estaSuspendido()
        {
            return (this.faltasAcumuladas > 3);   // ---> metodo mas elaborado!!!

            //if (faltasAcumuladas > 3)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
        public int valoracion()
        {
            //int valoracion = 5;
            //if (!lesionado & faltasAcumuladas == 0)
            //{
            //    valoracion = 10;
            //}
            //return valoracion;

            if (lesionado == false & faltasAcumuladas == 0) // otra implementación válida
            {
                return 10;
            }
            else
            {
                return 5;
            }
        }
        public override string ToString()
        {
            return base.ToString() + "|" + "Posicion: " + posicion + " Lesionado: " + lesionado + " Faltas Acumuladas: " + faltasAcumuladas;
        }
    }
}
