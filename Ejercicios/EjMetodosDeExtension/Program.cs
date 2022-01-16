using System;

namespace EjMetodosDeExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = 0;
            Console.WriteLine("Ingresar numero");

            string aux = Console.ReadLine();

            try
            {
                num = long.Parse(aux);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("El numero ingresado es " + num);

            Console.WriteLine("La cantidad de digitos del numero es: "+num.CantidadDigitos());
        }
    }

    // Clase estatica donde se guardan los metodos de extension.(Tiene que ser estatica si o si)
    public static class ClaseExtension
    {
        public static long CantidadDigitos(this long i)
        {
            string aux = i.ToString();

            long retorno = aux.Length;

            return retorno;
        }

        public static string ContarSignos(this string cadena)
        {

        }

    }
}
