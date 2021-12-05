using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej20
{
    class Peso : Dinero
    {


        private Peso()
        {
            this.CotizRespectoDolar = 201;
        }

        public Peso(double cantidad) : this()
        {
            this.Cantidad = cantidad;
        }

        public static explicit operator Peso(Euro e)
        {
            Peso p = new Peso(e.Cantidad);
            p.Cantidad = e.Cantidad * e.CotizRespectoDolar;
            return p;
        }

        public static explicit operator Peso(Dolar d)
        {
            Peso p = new Peso(d.Cantidad);
            p.Cantidad = p.Cantidad * p.CotizRespectoDolar;
            return p;
        }

        public static implicit operator Peso(double d)
        {
            Peso p = new Peso(d);
            return p;
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            if (d.Cantidad == (p.Cantidad * p.CotizRespectoDolar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Peso p, Dolar d)
        {
            return !(d == p);
        }

        public static bool operator ==(Peso p1, Peso  p2)
        {
            if (p1.Cantidad == p2.Cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Peso p, Euro e)
        {
            if (e.Cantidad == (p.Cantidad / p.CotizRespectoDolar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Peso p, Euro e)
        {
            return !(e == p);
        }

        public static Peso operator +(Euro e, Peso p)
        {
            return p.Cantidad + (e.Cantidad * e.CotizRespectoDolar * p.CotizRespectoDolar);
        }

        public static Peso operator +(Dolar d, Peso p)
        {
            return p.Cantidad + (d.Cantidad * p.CotizRespectoDolar);
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            return p.Cantidad - (d.Cantidad * p.CotizRespectoDolar);
        }

        public static Peso operator -(Euro d, Peso p)
        {
            return d.Cantidad - (p.Cantidad / p.CotizRespectoDolar);
        }
    }
}
