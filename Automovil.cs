using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomovilApp
{
    class Automovil
    {
        //atributos:
        private int odometro; //cantidad de km recorridos
        private int ltsActuales;
        private int capacidad;
        private int reserva;
        private int consumo;

        public Automovil() //Constructores
        {
            odometro = 0;
            ltsActuales = 0;
            capacidad = 49;
            reserva = 5;
            consumo = 11;
        }
        public Automovil(int km, int ltsActuales):this()
        {
            odometro = km;
            this.ltsActuales = ltsActuales;

        }
        //propiedades:
        public int Odometro
        {
            get { return odometro; }
            set { odometro = value; }
        }
        public int LtsActuales
        { 
            get { return ltsActuales; }
            set { ltsActuales = value; }
        }
        public int Capacidad
        { get { return capacidad; } }

        public int Reserva
        { get { return reserva; } }

        public int Consumo
        { get { return consumo;  } }
        //Metodos de control:
        public bool Conducir(int km)
        {
            bool aux = false;

            int ltsnecesarios = km / consumo;
            if (ltsActuales >= ltsnecesarios)
            {
                aux = true;
                odometro += km;
                ltsActuales -= ltsnecesarios;

            }
            return aux;
        }
        public int CargarCombustible(int lts)
        {
            int aux = 0;
            int capacidadTotal = capacidad + reserva;
            int ltsAux = ltsActuales + lts;
            if(ltsActuales + lts >= capacidadTotal)
            {
                aux = capacidadTotal - ltsAux;
                ltsActuales = capacidadTotal;

            }
            else
            {
                ltsActuales += lts;
            }
            return aux;
        }
        override //se puede usar el override que reescribr o omitirlo y al llamar auto2 xej usar el .ToString
        public string ToString()
        {
            return "km: " + odometro + " |Nivel de combustible: " + ltsActuales;
        }
    }
}