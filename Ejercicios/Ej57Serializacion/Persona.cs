using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej57Serializacion
{
    class Persona
    {
        private string nombre;
        private string apellido;

        public Persona ()
        {
            
        }

        public Persona(string nom, string ape)
        {
            this.nombre = nom;
            this.apellido = ape;
        }

        public static void Guardar()
        {

        }

    }
}
