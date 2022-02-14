using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej64Hilos_
{
    class Caja
    {
        private List<String> filaClientes;

        public List<String> FilaClientes
        {
            set
            {
                this.filaClientes = value;
            }
            get
            {
                return this.filaClientes;
            }
        }


        public void AtenderClientes()
        {
            foreach(String s in this.FilaClientes)
            {
                Console.WriteLine("Nombre: "+ s + "En el hilo: " + Task.CurrentId);
                Task.Delay(2000);
            }

        }

        public Caja()
        {
            this.filaClientes = new List<string>();

            
        }


    }
}
