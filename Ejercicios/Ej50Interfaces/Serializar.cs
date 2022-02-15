using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Ej50Interfaces
{
    public class Serializar<S,V>
    {
        public bool Guardar(S obj)
        {
            return true;
        }

        public V Leer()
        {
            string objetoJson = "";
            string ruta = "";
            try
            {
                objetoJson = File.ReadAllText(ruta);
            }
            catch (Exception)
            {
                throw new ErrorCargarArchivoException("Error al cargar el .json");
            }

            V objetoAux = JsonSerializer.Deserialize<V>(objetoJson);

            return objetoAux;
        }
    }
}
