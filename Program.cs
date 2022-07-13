using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLiga
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // Se crean 10 jugadores
            Jugador j1 = new Jugador("emiliano", "martinez", "0+", DateTime.Today, "arquero", false, 0);
            Jugador j2 = new Jugador("nicolas", "tagliafico", "0+", DateTime.Today, "defensor", false, 3);
            Jugador j3 = new Jugador("cuti", "romero", "0+", DateTime.Today, "defensor", false, 0);
            Jugador j4 = new Jugador("nicolas", "otamendi", "0+", DateTime.Today, "defensor", true, 5);
            Jugador j5 = new Jugador("rodrigo", "depaul", "0+", DateTime.Today, "mediocampista", false, 0);
            Jugador j6 = new Jugador("lo", "celco", "0+", DateTime.Today, "mediocampista", false, 0);
            Jugador j7 = new Jugador("leandro", "paredes", "0+", DateTime.Today, "mediocampista", false, 6);
            Jugador j8 = new Jugador("leonel", "messi", "0+", DateTime.Today, "delantero", false, 0);
            Jugador j9 = new Jugador("fideo", "dimaria", "0+", DateTime.Today, "delantero", true, 0);
            Jugador j10 = new Jugador("lautaro", "martinez", "0+", DateTime.Today, "delantero", false, 0);

            Console.WriteLine("Ingrese su Fecha de Nacimiento:");
            j1.pfecha_nacimiento = Convert.ToDateTime( Console.ReadLine()); // ejemplo como ingresar una fecha por consola

            // Se crea un equipo para 10 jugadores
            Equipo escaloneta = new Equipo(1, "ARG1", 10);

            // Se cargan los 10 jugadores al equipo
            escaloneta.agregarJugador(j1);
            escaloneta.agregarJugador(j2);
            escaloneta.agregarJugador(j3);
            escaloneta.agregarJugador(j4);
            escaloneta.agregarJugador(j5);
            escaloneta.agregarJugador(j6);
            escaloneta.agregarJugador(j7);
            escaloneta.agregarJugador(j8);
            escaloneta.agregarJugador(j9);
            escaloneta.agregarJugador(j10);

            Console.WriteLine("Listado");
            Console.WriteLine(escaloneta.listarJugadores());
            
            Console.WriteLine("Jugadores Suspendidos");
            Console.WriteLine(escaloneta.jugadoresSuspendidos());
            
            Console.WriteLine("Mediocampista 10");
            Console.WriteLine(escaloneta.mediocampista10());
            
            Console.WriteLine("Mejor Delantero");
            Console.WriteLine(escaloneta.mejorDelantero());
            
            Console.WriteLine("Posicion con valoracion");
            Console.WriteLine(escaloneta.posicionConValoracion("delantero", 10));
            
            Console.WriteLine("Valoracion promedio");
            Console.WriteLine(escaloneta.valoracionPromedio());
            
            Console.ReadLine();
        }
    }
}
