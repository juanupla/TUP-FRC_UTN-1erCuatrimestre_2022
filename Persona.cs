using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLiga
{
    class Persona
    {
        //Atributos
        protected string nombre, apellido, grupoSangineo;
        protected DateTime fecha_nacimiento;


        //Constructor
        public Persona()
        {
            nombre = string.Empty;
            apellido = string.Empty;
            grupoSangineo = string.Empty;
            fecha_nacimiento =  DateTime.Today;

        }
        public Persona(string nombre, string apellido, string grupoSangineo, DateTime fecha_nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.grupoSangineo = grupoSangineo;
            this.fecha_nacimiento = fecha_nacimiento;
        }
        //Metodo
        public override string ToString()
        {
            return "Nombre: " + this.nombre + " Apellido: " + apellido + " Grupo sangineo: " + grupoSangineo + " Fecha Nacimiento: " + fecha_nacimiento;
        }
        //Propiedades
        public string pNombre
        {
            get { return nombre; }

            set { nombre = value; }

        }
        public string pApellido
        {
            set { apellido = value; }
            get { return apellido; }
        }
        public string pGrupoSangineo
        {
            get { return grupoSangineo; }
            set { grupoSangineo = value; }
        }
        public DateTime pfecha_nacimiento
        {
            set { fecha_nacimiento = value; }
            get { return fecha_nacimiento; }
        }


    }
}
