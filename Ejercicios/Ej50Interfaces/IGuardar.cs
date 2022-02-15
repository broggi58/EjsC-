using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej50Interfaces
{
    public interface IGuardar<T,V>
    {
        public bool Guardar(Task obj);

        public V Leer();
    }
}
