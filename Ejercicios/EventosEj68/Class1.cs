using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosEj68
{
    public delegate void DelegadoString(string msg);
    public class Persona
    {
        private string apellido;
        private string nombre;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Apellido:" + this.Apellido);
            return sb.ToString();
        }

       public Persona()
        {
            this.Nombre = string.Empty;
            this.Apellido = string.Empty;
        }

        public event DelegadoString EventoString;

        public void MostrarEvento(string nombre, string apellido)
        {
            if(this.EventoString!=null && nombre!= this.Nombre && apellido!= this.Apellido)
            {
                this.EventoString("El usuario cambio.");
            }
            
        }


    }
}
