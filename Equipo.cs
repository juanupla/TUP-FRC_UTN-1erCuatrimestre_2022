using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLiga
{
    class Equipo
    {
        //Atributos
        private int categoria;
        private Jugador[] jugadores;
        private string denominacion;
        private int ultimo;     //atributo para tener en cuenta donde agregar cada jugador hasta completar el arreglo comenzando desde 0
        //Constru
        public Equipo(int categoria, string denominacion, int cantidadJugadores)
        {
            this.categoria = categoria;
            this.denominacion = denominacion;
            this.jugadores = new Jugador[cantidadJugadores];
            ultimo = 0;
        }
        public Equipo()
        {
            categoria = 0;
            denominacion = string.Empty;
            jugadores = new Jugador[11];
            ultimo = 0;
        }
        public Equipo(int cantidadJugadores)
        {
            categoria = 0;
            denominacion = string.Empty;
            jugadores = new Jugador[cantidadJugadores];
            ultimo = 0;
        }
        //Prop
        public int Pcategoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public string Pdenominacion
        {
            get { return denominacion; }
            set { denominacion = value; }
        }
        //Metodos
        public bool agregarJugador(Jugador unJugador)
        {
            if (ultimo < jugadores.Length)
            {
                jugadores[ultimo] = unJugador;
                ultimo++;
                return true;
            }
            else
            {
                return false; 
            }
        }

        public string listarJugadores()
        {
            string jugadoress = "";
            string separador = " | ";
            for (int i = 0; i < ultimo; i++)
            {
                jugadoress += jugadores[i].pApellido + " " + jugadores[i].pNombre + separador;
            }
            return jugadoress;
        }
        public string jugadoresSuspendidos()
        {
            //string jugadoress = "";
            //string separador = " | ";
            //for (int i = 0; i < ultimo; i++)
            //{
            //    if (jugadores[i].estaSuspendido())
            //    {
            //        jugadoress += jugadores[i].pApellido + " " + jugadores[i].pNombre + separador;
            //    }
            //}
            //return jugadoress;

            string jugadoresSuspendidos = "";       //otra implementación válida con foreach

            foreach (Jugador jugador in jugadores)
            {
                if (jugador.estaSuspendido())
                    jugadoresSuspendidos += jugador.pApellido + ", " + jugador.pNombre + "\n";
            }

            return jugadoresSuspendidos;

        }

        public int posicionConValoracion(string posicion, int valoracion)
        {
            int cantidad = 0;
            for (int i = 0; i < ultimo; i++)
            {
                if (jugadores[i].pPosicion == posicion & valoracion == jugadores[i].valoracion())
                {
                    cantidad++;
                }
            }
            return cantidad;
        }

        public string mediocampista10()
        {
            string mediocampista = "";
            string separador = " | ";
            for (int i = 0; i < jugadores.Length; i++)
            {
                if (jugadores[i].pPosicion == "mediocampista" & jugadores[i].valoracion() == 10 & !(jugadores[i].Plesionado))
                {
                    mediocampista += jugadores[i].ToString() + separador;
                    // mediocampista += jugadores[i].pNombre + separador + jugadores[i].pApellido + separador + jugadores[i].pPosicion;
                }
            }
            if (mediocampista.Length == 0)
            {
                return "NO encontrado";
            }
            return mediocampista;
        }

        public double valoracionPromedio()
        {
            double acumulador = 0;
            for (int i = 0; i < ultimo; i++)
            {
                acumulador += jugadores[i].valoracion();
            }
            return Math.Round((acumulador / ultimo),2);
        }

        public string mejorDelantero()
        {
            Jugador elMejor = null;         // utilizando un objeto en lugar de variables
            //int mejor = jugadores[0].valoracion();
            //string mejordelantero = "";
            for (int i = 0; i < ultimo; i++)
            {
                if (jugadores[i].pPosicion == "delantero")
                {
                    if (elMejor == null)    //sería el primer "delantero"
                        {
                            elMejor = jugadores[i];
                        }
                    else
                        if (jugadores[i].valoracion() > elMejor.valoracion())  //if (jugadores[i].valoracion() > mejor)
                        {
                            elMejor = jugadores[i];
                            //mejor = jugadores[i].valoracion();
                            //mejordelantero = jugadores[i].ToString();
                        }
                }
            }
            if (elMejor != null)
                //return mejordelantero;
                return elMejor.ToString();
            else
                return "No se encontraron delanteros en el equipo!!!";
        }
    }
}
