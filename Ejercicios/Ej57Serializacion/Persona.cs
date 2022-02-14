using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

        public static void Guardar(Persona objeto)
        {
                try
                {
                    using (StreamWriter streamWriter = new StreamWriter(""))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));
                        xmlSerializer.Serialize(streamWriter, objeto);
                    }
                }
                catch (Exception)
                {
                    throw new ErrorArchivoException("Error al guardar el archivo.");
                }   
        }

        public static Persona Leer()
           
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(""))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));
                    Persona objeto = xmlSerializer.Deserialize(streamReader) as Persona;
                    return objeto;
                }
            }
            catch (Exception)
            {
                throw new ErrorArchivoException("Error al cargar el archivo.");
            }
        }

    }
}
