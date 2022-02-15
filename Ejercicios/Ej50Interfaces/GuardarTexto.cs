using System;
using System.IO;

namespace Ej50Interfaces
{
    public class GuardarTexto<T,V>
    {
        public bool Guardar(T obj)
        {
            return true;
        }

        public V Leer()
        {
            V retorno;
            string aux = "";
            string ruta = "";

            StreamReader sr = new StreamReader(ruta);

            // Leo una línea de texto

            aux = sr.ReadToEnd();

            // Cierro el archivo

            sr.Close();
            retorno = (V)Convert.ChangeType(aux, typeof(V));

            return retorno;
        }
    }
}
